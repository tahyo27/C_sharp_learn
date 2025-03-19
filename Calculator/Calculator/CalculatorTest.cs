
using Domain;
using FluentAssertions;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        // TDD: 테스트를 먼저 작성 시나리오 생각하기
        // 시나리오를 생각해서 테스트 코드를 먼저 작성하고
        // 테스트도 차례차례 일단 리턴 먼저 하게 만드는듯
        // 그 이후에 프로덕션 코드를 작성
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        => new Calculator().Sum(2, 2).Should().Be(2);
        // Sum 메서드의 미래를 적고있음
        //var calculator = new Calculator();
        //var result = calculator.Sum(2, 2);

        //result.Should().Be(4);
        // 이렇게 하지말고 Fluent Assertion Nuget 패키지에서 받아 사용
        //if(result != 4)
        //{
        //    
        //    throw new Exception($"The Sum(2, 2) was expected to be 4 but it's {result}");
        //}



    }
}