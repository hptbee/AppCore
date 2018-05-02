namespace ACF.Application.Contracts.Common
{
    public class ActionResultDto
    {
        #region Properties

        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        #endregion Properties
        #region Constructors

        public ActionResultDto()
        {
            SetInfo(false, null);
        }

        public ActionResultDto(bool isSuccess, string message)
        {
            SetInfo(isSuccess, message);
        }

        #endregion Constructors
        #region Methods

        public void SetInfo(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }

        public void SetInfo(ActionResultDto actResult)
        {
            SetInfo(actResult.IsSuccess, actResult.Message);
        }

        #endregion Methods
    }
}
