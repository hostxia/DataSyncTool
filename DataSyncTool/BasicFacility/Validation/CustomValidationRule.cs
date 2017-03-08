using DevExpress.XtraEditors.DXErrorProvider;

namespace BasicFacility.Validation
{
    public class CustomValidationRule
    {
        public static ConditionValidationRule NotEmpty = new ConditionValidationRule
                                                             {
                                                                 ConditionOperator = ConditionOperator.IsNotBlank,
                                                                 ErrorText = Properties.Resource.Validation_Not_Empty
                                                             };

        public static ConditionValidationRule LookupEditNeedChoosing = new ConditionValidationRule
                                                                           {
                                                                               ConditionOperator = ConditionOperator.NotEquals,
                                                                               Value1 = "",
                                                                               Value2 = 0,
                                                                               ErrorText = Properties.Resource.Validation_LookupEdit_Need_Choosing
                                                                           };

        public static ConditionValidationRule GridLookupEditNeedChoosing = new ConditionValidationRule
                                                                               {
                                                                                   ConditionOperator = ConditionOperator.NotEquals,
                                                                                   Value1 = "",
                                                                                   Value2 = null,
                                                                                   ErrorText = Properties.Resource.Validation_LookupEdit_Need_Choosing
                                                                               };
    }
}