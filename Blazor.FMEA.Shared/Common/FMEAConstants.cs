using System;
using System.Collections.Generic;
using System.Text;

namespace Blazor.FMEA.Shared.Common
{
    public static class FMEAConstants
    {
        //Master: Product Characteristics
        public const string PD_Characteristics_ID = "PD_Characteristics_ID";
        public const string PD_Characteristics_Desc = "PD_Characteristics_Desc";

        public const string InsertProductCharacteristicsSuccessful = "ProductCharacteristics record added successfully.";
        public const string InsertProductCharacteristicsFailed = "Add new ProductCharacteristics failed.";
        public const string UpdateProductCharacteristicsSuccessful = "ProductCharacteristics record updated successfully.";
        public const string UpdateProductCharacteristicsFailed = "Modify ProductCharacteristics failed.";
        public const string DeleteProductCharacteristicsSuccessful = "ProductCharacteristics record deleted successfully.";
        public const string DeleteProductCharacteristicsFailed = "Delete ProductCharacteristics failed.";

        //Master: Product
        public const string Product_Class = "Product_Class";
        public const string Essex_Specification = "Essex_Specification";
        public const string ProductMaster = "Product Master";

        //Record Insert/Update/Delete Messages
        public const string RecordInsertSuccessful = " record added successfully.";
        public const string RecordInsertFail = " add new record action failed.";
        public const string RecordUpdateSuccessful = " record updated successfully.";
        public const string RecordUpdateFail = " modify record action failed.";
        public const string RecordDeleteSuccessful = " record deleted successfully.";
        public const string RecordDeleteFail = " delete record action failed.";

        //Master: Site Master
        public const string Site_Number = "Site_Number";
        public const string Site_Abbr = "Site_Abbr";
        public const string Site_Desc = "Site_Desc";
        public const string Site_Operational = "Site_Operational";

        public const string InsertSiteMasterSuccessful = "SiteMaster record added successfully.";
        public const string InsertSiteMasterFailed = "Add new SiteMaster failed.";
        public const string UpdateSiteMasterSuccessful = "SiteMaster record updated successfully.";
        public const string UpdateSiteMasterFailed = "Modify SiteMaster failed.";
        public const string DeleteSiteMasterSuccessful = "SiteMaster record deleted successfully.";
        public const string DeleteSiteMasterFailed = "Delete SiteMaster failed.";

        //Master: Detection Master
        public const string Detection_ID = "Detection_ID";
        public const string Detection_Method = "Detection_Method";
        public const string Test_Method = "Test_Method";

        public const string InsertDetectionMethodSuccessful = "DetectionMethod record added successfully.";
        public const string InsertDetectionMethodFailed = "Add new DetectionMethod failed.";
        public const string UpdateDetectionMethodSuccessful = "DetectionMethod record updated successfully.";
        public const string UpdateDetectionMethodFailed = "Modify DetectionMethod failed.";
        public const string DeleteDetectionMethodSuccessful = "DetectionMethod record deleted successfully.";
        public const string DeleteDetectionMethodFailed = "Delete DetectionMethod failed.";

        //Master: Escape Master
        public const string Escape_ID = "Escape_ID";
        public const string Escape_Impact = "Escape_Impact";
        public const string Escape_Description = "Escape_Description";
        public const string Escape_ID_Description = "Escape_ID_Description";
        public const string Escape_Master = "Escape Master";

        public const string InsertEscapeMasterSuccessful = "EscapeMaster record added successfully.";
        public const string InsertEscapeMasterFailed = "Add new EscapeMaster failed.";
        public const string UpdateEscapeMasterSuccessful = "EscapeMaster record updated successfully.";
        public const string UpdateEscapeMasterFailed = "Modify EscapeMaster failed.";
        public const string DeleteEscapeMasterSuccessful = "EscapeMaster record deleted successfully.";
        public const string DeleteEscapeMasterFailed = "Delete EscapeMaster failed.";

        //Master: Product Failure
        public const string PFM_ID = "PFM_ID";
        public const string PFM_Description = "PFM_Description";

        public const string InsertProductFailureMasterSuccessful = "ProductFailure record added successfully.";
        public const string InsertProductFailureMasterFailed = "Add new ProductFailure failed.";
        public const string UpdateProductFailureMasterSuccessful = "ProductFailure record updated successfully.";
        public const string UpdateProductFailureMasterFailed = "Modify ProductFailure failed.";
        public const string DeleteProductFailureMasterSuccessful = "ProductFailure record deleted successfully.";
        public const string DeleteProductFailureMasterFailed = "Delete ProductFailure failed.";

        //Master: Customer Failure
        public const string Customer_Failure_ID = "Customer_Failure_ID";
        public const string Customer_Failure_Mode = "Customer_Failure_Mode";
        public const string Serverity_ID = "Serverity_ID";
        public const string Customer_Failure_Master = "Customer_Failure_Master";

        public const string InsertCustomerFailureMasterSuccessful = "CustomerFailure record added successfully.";
        public const string InsertCustomerFailureMasterFailed = "Add new CustomerFailure failed.";
        public const string UpdateCustomerFailureMasterSuccessful = "CustomerFailure record updated successfully.";
        public const string UpdateCustomerFailureMasterFailed = "Modify CustomerFailure failed.";
        public const string DeleteCustomerFailureMasterSuccessful = "CustomerFailure record deleted successfully.";
        public const string DeleteCustomerFailureMasterFailed = "Delete CustomerFailure failed.";

        //Master: Cause Of Failure
        public const string COF_ID = "COF_ID";
        public const string Potential_Cause_Of_Failure = "Potential_Cause_Of_Failure";

        public const string InsertCauseOfFailureMasterSuccessful = "CauseOfFailure record added successfully.";
        public const string InsertCauseOfFailureMasterFailed = "Add new CauseOfFailure failed.";
        public const string UpdateCauseOfFailureMasterSuccessful = "CauseOfFailure record updated successfully.";
        public const string UpdateCauseOfFailureMasterFailed = "Modify CauseOfFailure failed.";
        public const string DeleteCauseOfFailureMasterSuccessful = "CauseOfFailure record deleted successfully.";
        public const string DeleteCauseOfFailureMasterFailed = "Delete CauseOfFailure failed.";

        //Master: Control Method
        public const string Control_Method_ID = "Control_Method_ID";
        public const string Control_Method_Description = "Control_Method_Description";

        public const string InsertControlMethodMasterSuccessful = "ControlMethod record added successfully.";
        public const string InsertControlMethodMasterFailed = "Add new ControlMethod failed.";
        public const string UpdateControlMethodMasterSuccessful = "ControlMethod record updated successfully.";
        public const string UpdateControlMethodMasterFailed = "Modify ControlMethod failed.";
        public const string DeleteControlMethodMasterSuccessful = "ControlMethod record deleted successfully.";
        public const string DeleteControlMethodMasterFailed = "Delete ControlMethod failed.";

        //Master: Occurrence Master
        public const string Occurrence_ID = "Occurrence_ID";
        public const string Occurrence_Impact = "Occurrence_Impact";
        public const string Occurrence_Description = "Occurrence_Description";
        public const string Occurrence_ID_Description = "Occurrence_ID_Description";

        public const string InsertOccurrenceMasterSuccessful = "Occurrence record added successfully.";
        public const string InsertOccurrenceMasterFailed = "Add new Occurrence failed.";
        public const string UpdateOccurrenceMasterSuccessful = "Occurrence record updated successfully.";
        public const string UpdateOccurrenceMasterFailed = "Modify Occurrence failed.";
        public const string DeleteOccurrenceMasterSuccessful = "Occurrence record deleted successfully.";
        public const string DeleteOccurrenceMasterFailed = "Delete Occurrence failed.";

        //Master: Severity Master
        public const string Severity_ID = "Severity_ID";
        public const string Severity_Impact = "Severity_Impact";
        public const string Severity_Description = "Severity_Description";
        public const string Severity_Master = "Severity Master";

        //Detection Method Form
        public const string Site = "Site";
        public const string Detection_Master_ID = "Detection_Master_ID";
        public const string Detection_Method_Form = "Detection Method Form";

        public const int DropDownDefault_ID = 0;

        //Master: Product Characteristics
        public const string Product_Characteristic_ID = "Product_Characteristic_ID";
        public const string Product_Characteristic_Description = "Product_Characteristic_Description";

        public const string InsertCharacteristicsSuccessful = "Characteristics record added successfully.";
        public const string InsertCharacteristicsFailed = "Add new Characteristics failed.";
        public const string UpdateCharacteristicsSuccessful = "Characteristics record updated successfully.";
        public const string UpdateCharacteristicsFailed = "Modify Characteristics failed.";
        public const string DeleteCharacteristicsSuccessful = "Characteristics record deleted successfully.";
        public const string DeleteCharacteristicsFailed = "Delete Characteristics failed.";

        //Master: Customer Failure Mode
        public const string Customer_Failure_Mode_Desc_FK = "Customer_Failure_Mode_Desc_FK";
        public const string Product_Failure_Mode_Desc_FK = "Product_Failure_Mode_Desc_FK";

        public const string InsertCustomer_Failure_ModeSuccessful = "Customer_Failure_Mode record added successfully.";
        public const string InsertCustomer_Failure_ModeFailed = "Add new Customer_Failure_Mode failed.";
        public const string UpdateCustomer_Failure_ModeSuccessful = "Customer_Failure_Mode record updated successfully.";
        public const string UpdateCustomer_Failure_ModeFailed = "Modify Customer_Failure_Mode failed.";
        public const string DeleteCustomer_Failure_ModeSuccessful = "Customer_Failure_Mode record deleted successfully.";
        public const string DeleteCustomer_Failure_ModeFailed = "Delete Customer_Failure_Mode failed.";

        //Product Failure Mode
        public const string PFM_Desc_ID_FK = "PFM_Desc_ID_FK";
        public const string Product_Failure_Mode = "Product Failure Mode";

        //Form: Control Method Form
        public const string Control_ID = "Control_ID";
        public const string CoF_ID_FK = "CoF_ID_FK";
        public const string Site_FK = "Site_FK";
        public const string Occurrence_ID_FK = "Occurrence_ID_FK";

        public const string InsertControlMethodFormSuccessful = "ControlMethodForm record added successfully.";
        public const string InsertControlMethodFormFailed = "Add new ControlMethodForm failed.";
        public const string UpdateControlMethodFormSuccessful = "ControlMethodForm record updated successfully.";
        public const string UpdateControlMethodFormFailed = "Modify ControlMethodForm failed.";
        public const string DeleteControlMethodFormSuccessful = "ControlMethodForm record deleted successfully.";
        public const string DeleteControlMethodFormFailed = "Delete ControlMethodForm failed.";

        //Form: Cause Of Failure Form

        public const string Failure_ID = "Failure_ID";

        public const string InsertCauseOfFailureFormSuccessful = "CauseOfFailureForm record added successfully.";
        public const string InsertCauseOfFailureFormFailed = "Add new CauseOfFailureForm failed.";
        public const string UpdateCauseOfFailureFormSuccessful = "CauseOfFailureForm record updated successfully.";
        public const string UpdateCauseOfFailureFormFailed = "Modify CauseOfFailureForm failed.";
        public const string DeleteCauseOfFailureFormSuccessful = "CauseOfFailureForm record deleted successfully.";
        public const string DeleteCauseOfFailureFormFailed = "Delete CauseOfFailureForm failed.";

        //Product Characteristic Report
        public const string Product_Class_Selected = "Product_Class_Selected";
    }
}
