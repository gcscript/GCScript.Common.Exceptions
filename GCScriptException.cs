namespace GCScript.Common.Exceptions;
public class GCScriptException : System.Exception {
	public int Code { get; }

	public GCScriptException(int code, string message = "An unexpected error occurred =(")
		: base(message) {
		Code = code;
	}

	public override string ToString() {
		return $"GCScriptException: {Code} - {Message}\n{StackTrace}";
	}
}
