
using Domain;
using FluentAssertions;

namespace CalculatorTest
{
    public class CalculatorTest
    {
        // TDD: �׽�Ʈ�� ���� �ۼ� �ó����� �����ϱ�
        // �ó������� �����ؼ� �׽�Ʈ �ڵ带 ���� �ۼ��ϰ�
        // �׽�Ʈ�� �������� �ϴ� ���� ���� �ϰ� ����µ�
        // �� ���Ŀ� ���δ��� �ڵ带 �ۼ�
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        => new Calculator().Sum(2, 2).Should().Be(2);
        // Sum �޼����� �̷��� ��������
        //var calculator = new Calculator();
        //var result = calculator.Sum(2, 2);

        //result.Should().Be(4);
        // �̷��� �������� Fluent Assertion Nuget ��Ű������ �޾� ���
        //if(result != 4)
        //{
        //    
        //    throw new Exception($"The Sum(2, 2) was expected to be 4 but it's {result}");
        //}



    }
}