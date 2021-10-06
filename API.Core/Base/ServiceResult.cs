namespace API.Core.Base
{
	public class ServiceResult<T> : ServiceResult
	{
		public ServiceResult() { }

		public ServiceResult(string message, int statusCode) 
			: base(message, statusCode)
		{
		}
		
		public T Data { get; set; }
	}

	public class ServiceResult
	{
		public ServiceResult()
		{
		}

		public ServiceResult(string message, int statusCode)
		{
			Message = message;
			StatusCode = statusCode;
		}

		public string Message { get; set; }

		public int StatusCode { get; set; }
	}
}
