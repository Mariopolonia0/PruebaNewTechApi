namespace PruebaNewTechApi.Model.Dto
{
    public class Result
    {
        public string DataResult { get; set; }
        public Result(string _dataResult)
        {
            DataResult = _dataResult;
        }
        public Result()
        {
            DataResult = "";
        }
    }
}