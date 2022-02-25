namespace Helper.Methods
{
    public class SEO
    {
        public string SeoURL(string link)
        {
            link = link.ToLower()
                .Replace("ə","e")
                .Replace("ğ","g")
                .Replace(" ","-")
                .Replace("ç","c")
                .Replace("ü","a")
                .Replace("ç","c")
                .Replace("ö","o");



            return link;

        }



    }
}
