namespace NumberForAdd.Models
{
    public class NumberToBeAddedModel
    {
        private int _num;

        public NumberToBeAddedModel(int num) { 
            _num = num;
        }
        public int GetNum()
        {
            return _num;
        }
    }
}
