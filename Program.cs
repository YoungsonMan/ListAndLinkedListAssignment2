namespace ListAndLinkedListAssignment2
{/*************************************************************************************
 * 리스트와 링크드리스트 과제2
 * YC
 * 2024-07-31 
 * 과제 2. 요세푸스 순열
 * 아래의 요세푸스 순열에 대한 설명을 보고 N 과 K 가 주어지면 결과를 출력하는 프로그램으로 구현하시오
 *      1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고
 *      양의 정수 K ( <= N ) 가 주어진다.
 *      이제 순서대로 K번째 사람을 제거한다.
 *      한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다.
 *      이 과정은 N명의 사람이 모두 제거될 때까지 계속된다.
 *      원에서 사람들이 제거되는 순서를 (N,K) - 오세푸스 순열이라고 한다.
 *      예를 들어 (7,3) - 오세푸스 순열은 < 3, 6, 2, 7, 5, 1, 4 > 이다.
 *
 **************************************************************************************/
    internal class Program
    {

        static void Main(string[] args)
        {
            string input1, input2;
            int n;
            int k;
            int index, temp;

            // getting input
            // input n
            Console.WriteLine("사람수(n)을 입력하세요");
            input1 = Console.ReadLine();
            bool success1 = int.TryParse(input1, out n);
            // input k
            Console.WriteLine("몇번째(k) 사람마다 죽을지 입력하세요 ");
            input2 = Console.ReadLine();
            bool success2 = int.TryParse(input2, out k);



            temp = 0;

            
            // List
            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i <= n; i++)
            {
                list.AddLast(i);
            }

            var round = list.First;
            index = ((temp + k) % list.Count);

            while (n != 0)
            {
                // 이게 계속 7 넘어갈때 list[0]에 0 을 카운트 하고 넘어가서 숫자가 꼬이는거같다.
                for(int j = 0; j < k; j++)
                {
                    if (round.Next == null)
                    {
                        round = list.First;
                    }
                    else
                    {
                        round = round.Next;
                    }
                }
                if (list.Count == 1)
                {
                    Console.Write(round.Value + " ");
                }
                else
                {
                    Console.Write(round.Value + " ");
                }
                
                n--;

            }

        }
    }
}
