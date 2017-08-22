using System.Collections.Generic;
using System.Threading.Tasks;
using JsonApiDotNetCore.Models;
using JsonApiDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JsonApiDotNetCore.Controllers;
using JsonApiDotNetCore.Data;
using System.Linq;
using HC.Common;
using HC.Patient.Entity;

namespace HC.Patient.Web
{
    public class CustomJsonApiController<T>
    : CustomJsonApiController<T, int> where T : class, IIdentifiable<int>
    {

        public CustomJsonApiController(
            IJsonApiContext jsonApiContext,
            IResourceService<T, int> resourceService,
            ILoggerFactory loggerFactory)
            : base(jsonApiContext, resourceService, loggerFactory)
        {

        }
    }

    public class CustomJsonApiController<T, TId>
    : JsonApiController<T, TId> where T : class, IIdentifiable<TId>
    {
        private readonly IDbContextResolver _dbContextResolver;
        public readonly IJsonApiContext _jsonApiContext;
        public CustomJsonApiController(
            IJsonApiContext jsonApiContext,
            IResourceService<T, TId> resourceService,
            ILoggerFactory loggerFactory)
        : base(jsonApiContext, resourceService)
        {

            _dbContextResolver = jsonApiContext.GetDbContextResolver();
            _jsonApiContext = jsonApiContext;
        }

        public CustomJsonApiController(
            IJsonApiContext jsonApiContext,
            IResourceService<T, TId> resourceService)
        : base(jsonApiContext, resourceService)
        {

            _dbContextResolver = jsonApiContext.GetDbContextResolver();
            _jsonApiContext = jsonApiContext;
        }

        [HttpGet]
        public override async Task<IActionResult> GetAsync() => await base.GetAsync();

        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(TId id) => await base.GetAsync(id);

        [HttpGet("{id}/relationships/{relationshipName}")]
        public override async Task<IActionResult> GetRelationshipsAsync(TId id, string relationshipName)
            => await base.GetRelationshipsAsync(id, relationshipName);

        [HttpGet("{id}/{relationshipName}")]
        public override async Task<IActionResult> GetRelationshipAsync(TId id, string relationshipName)
            => await base.GetRelationshipAsync(id, relationshipName);

        [HttpPost]
        public override async Task<IActionResult> PostAsync([FromBody] T entity)
            => await base.PostAsync(entity);

        [HttpPatch("{id}")]
        public override async Task<IActionResult> PatchAsync(TId id, [FromBody] T entity)
        {
            var attrToUpdate = _jsonApiContext.AttributesToUpdate;
            var patientInfoOld = _dbContextResolver.GetDbSet<T>().Where(m => m.Id.Equals(id)).FirstOrDefault();
            CommonMethods commonMethods = new CommonMethods();
            int eventID = _dbContextResolver.GetDbSet<Event>().AsQueryable().OrderByDescending(p => p.Id).FirstOrDefault().Id + 1;
            List<AuditLogs> auditLogs = commonMethods.GetAuditLogValues(patientInfoOld, entity, typeof(T).Name, attrToUpdate)
                .Select(q => new AuditLogs() { NewValue = q.NewValue, OldValue = q.OldValue, PrimaryKeyID = q.PrimaryKeyID,
                    TableName = q.TableName, PropertyName = q.PropertyName, EventID = eventID }).ToList();
            await _dbContextResolver.GetDbSet<AuditLogs>().AddRangeAsync(auditLogs);
            return await base.PatchAsync(id, entity);
        }

        [HttpPatch("{id}/relationships/{relationshipName}")]
        public override async Task<IActionResult> PatchRelationshipsAsync(
            TId id, string relationshipName, [FromBody] List<DocumentData> relationships)
            => await base.PatchRelationshipsAsync(id, relationshipName, relationships);

        [HttpDelete("{id}")]
        public override async Task<IActionResult> DeleteAsync(TId id) => await base.DeleteAsync(id);
    }
}
