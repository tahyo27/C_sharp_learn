
using Domain;

namespace CalculatorTest
{
    public class UnitTest1
    {
        // TDD: 테스트를 먼저 작성 시나리오 생각하기
        // 시나리오를 생각해서 테스트 코드를 먼저 작성하고
        // 테스트도 차례차례 일단 리턴 먼저 하게 만드는듯
        // 그 이후에 프로덕션 코드를 작성
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        {
            // Sum 메서드의 미래를 적고있음
            var calculator = new Calculator();
            var result = calculator.Sum(2, 2);
            if(result != 4)
            {
                throw new Exception();
            }
        }

       
    }
}