namespace Entities
{
    public class CountDownLanguage : Base
    {
        public string Title { get; set; }
        public string LangCode { get; set; }
        public int CountDownID { get; set; }
        public virtual CountDown CountDown { get; set; }
    }
}
