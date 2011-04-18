namespace Extensions {
  using System.Web;

  public static class StringExtensions {
    public static string UrlEncode(this string data) {
      return HttpUtility.UrlEncode(data);
    }

    public static string UrlDecode(this string data) {
      return HttpUtility.UrlDecode(data);
    }

    public static string[] Split(this string data, string separator) {
      return data == null ? new string[] {} : data.Split(separator.ToCharArray());
    }
  }
}
