using NumberForAdd.Models;
namespace Addition.Managers
{
    public class AdditionManager
    {
        public int AdditionMethod(NumberToBeAddedModel num1, NumberToBeAddedModel num2)
        {
            int number1 = num1.GetNum();
            int number2 = num2.GetNum();
            int sum = number1 + number2;

            AdditionResModel resObj = new AdditionResModel(sum);
            return resObj.GetSum();//this returns the result t
        }
    }
}
