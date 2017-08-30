using System;
using System.Collections.Generic;
using System.Text;

namespace HC.Common.Enums
{
    public class CommonEnum
    {
        /// <summary>
        /// Enumeration for master data for getting data from database on the basis on master table name
        /// </summary>
        public enum MasterDataEnum
        {
            MASTERCOUNTRY, MASTERDOCUMENTTYPE, MASTERETHNICITY, MASTERFUNDINGSOURCE,MASTERINSURANCEPCP, MASTERINSURANCETYPE, MASTEROCCUPATION, MASTERPREFERREDLANGUAGE,
            MASTERRACE,MASTERSTATE, MASTERSTATUS, SUFFIX, MASTERPROVIDER, MARITALSTATUS, RELATIONSHIP, MASTERPROGRAM,MASTERSERVICE, PATIENTSTATUS, MASTERINSURANCECOMPANY,
            MASTERPATIENTCOMMPREFERENCES, MASTERREFERRAL,MASTERGENDER, PHONETYPE, INSURANCEPLANTYPE, MASTERLOCATION, MASTERCPT, MASTERICD,
            MASTERVFC, MASTERIMMUNIZATION, MASTERMANUFACTURE, MASTERADMINISTRATIONSITE, MASTERROUTEOFADMINISTRATION, MASTERIMMUNITYSTATUS, MASTERREJECTIONREASON,
            SOCIALHISTORY,TRAVELHISTORY,
            ADDRESSTYPE,
            MASTERCLINICIAN,
            APPOINTMENTTYPE,
            LABTESTTYPE, MASTERLONIC, MASTERLABS, TIMETYPE, FREQUENCYTYPE, FREQUENCYDURATIONTYPE
        }

        /// <summary>
        /// Enumeration for patient search parameters for getting data on the basis of passed parameters
        /// </summary>
        public enum PatientSearch
        {
            FIRSTNAME, MIDDLENAME, LASTNAME, SSN, FROMDATE, TODATE, FROMDOB, TODOB, SEARCHKEY,ID, PROVIDERNAME, GENDER, DOB, PATIENTINSURANCE, CLINICIANNAME,STARTWITH
        }

        /// <summary>
        /// Enumeration for all data types
        /// </summary>
        public enum DataType
        {
            System_Boolean = 0,
            System_Int32 = 1,
            System_Int64 = 2,
            System_Double = 3,
            System_DateTime = 4,
            System_String = 5
        }
        public enum AttrToUpdate
        {
            PhotoPath,
            PhotoThumbnailPath,
            PhotoBase64,
            //For insurance
            InsurancePhotoPathFront,
            InsurancePhotoPathThumbFront,
            InsurancePhotoPathBack,
            InsurancePhotoPathThumbBack,
            //Vital
            BMI

        }
    }
}
