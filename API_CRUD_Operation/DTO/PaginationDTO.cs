namespace API_CRUD_Operation.DTO
{
    public class PaginationDTO
    {
        public int Page { get; set; } = 1;

        private int recordPerPage = 10;

        private int maxAmount = 50;
        public int RecordPerPage
        {
            get 
            { 
                return recordPerPage; 
            }
            set
            {
                recordPerPage = (value > maxAmount) ? maxAmount : value;
            }
        }
    }
}
