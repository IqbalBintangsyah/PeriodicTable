namespace TA_PBO
{
    class UnsurNama : Unsur
    {
        string url = "https://periodic-table-api.herokuapp.com/atomicName/";

        public UnsurResult ReturnValue(string unsur)
        {
            UnsurResult unsurResult = new UnsurResult();
            unsurResult = base.ReturnValue(url, unsur);
            return unsurResult;
        }
    }
}
