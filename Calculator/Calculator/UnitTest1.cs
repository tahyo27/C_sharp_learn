
using Domain;

namespace CalculatorTest
{
    public class UnitTest1
    {
        // TDD: �׽�Ʈ�� ���� �ۼ� �ó����� �����ϱ�
        // �ó������� �����ؼ� �׽�Ʈ �ڵ带 ���� �ۼ��ϰ�
        // �׽�Ʈ�� �������� �ϴ� ���� ���� �ϰ� ����µ�
        // �� ���Ŀ� ���δ��� �ڵ带 �ۼ�
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
        {
            // Sum �޼����� �̷��� ��������
            var calculator = new Calculator();
            var result = calculator.Sum(2, 2);
            if(result != 4)
            {
                throw new Exception();
            }
        }

       
    }
}