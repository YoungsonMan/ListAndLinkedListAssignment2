# About the Project
---

## “Josephus Problem”

List and LinkedList Assignment2.

### Goal 학습목표
---
 - 아래의 요세푸스 순열에 대한 설명을 보고 N 과 K 가 주어지면 결과를 출력하는 프로그램으로 구현하시오
 - 1번부터 N번까지 N명의 사람이 원을 이루면서 앉아있고
 - 양의 정수 K ( <= N ) 가 주어진다.
 - 이제 순서대로 K번째 사람을 제거한다.
 - 한 사람이 제거되면 남은 사람들로 이루어진 원을 따라 이 과정을 계속해 나간다.
 - 이 과정은 N명의 사람이 모두 제거될 때까지 계속된다.
 - 원에서 사람들이 제거되는 순서를 (N,K) - 오세푸스 순열이라고 한다.
 - 예를 들어 (7,3) - 오세푸스 순열은 < 3, 6, 2, 7, 5, 1, 4 > 이다.



### Built with
---
Visual Studio 2022 v17.10.3

Laguage used - C#

### Explanation
---
예시로 n=7, k=3 이라고 할때: 마지막 숫자인7 을 넘어갈때 list[0]에 0을 카운트하면서 넘어가면서 숫자가 꼬인다.
해결을 못했다...
아니 이게 뭔가 이해는 했는데 k=2에서는 확실히 이해를 했는데 3부터 뭔가 k-1로 죽는다는데 이게 왜 이게 뭔가왜가 왠지 알겠는데 모르겠음
알고리즘? 시스템? k번째 사람이 죽는거 이해는 했는데 이걸 그 구축하는게 뭔가 그게 뭔가가 그 햇갈린다.

Process of understanding
---
첫번째로, 다양한 데이터를 넣어보면서 패턴을 분석한다

| Number Of People ( N ) | nth Number To Kill ( K ) | Last Man Standing ( W ) |
| --- | --- | --- |
| 1 | 2 | 1 |
| 2 | 2 | 1 |
| 3 | 2 | 3 |
| 4 | 2 | 1 |
| 5 | 2 | 3 |
| 6 | 2 | 5 |
| 7 | 2 | 7 |
| 8 | 2 | 1 |
| 9 | 2 | 3 |
| 10 | 2 | 5 |
| 11 | 2 | 7 |
| 12 | 2 | 9 |
| 13 | 2 | 11 |
| 14 | 2 | 13 |
|  |  |  |

Let say: 

(n) = 16

(k) = 2

then, starting from 1, it would eliminate all even numbers which is a half (2,4,6,8,10,12,14,16)

1, ~~2~~, 3, ~~4~~, 5, ~~6~~, 7, ~~8~~, 9, ~~10~~, 11, ~~12~~, 13, ~~14~~, 15, ~~16~~

1, 3, 5, 7, 9, 11, 13, 15 would be surviver, and lets number them again.

1, 2, 3, 4, 5,  6,  7,   8
starts from 1,  even will eliminated again.

1, ~~2~~, 3, ~~4~~, 5, ~~6~~, 7, ~~8~~

1, ~~3~~, 5, ~~7~~

1, 5,

1


1 is surviving from peer power of 2 .    1, 2, 4, 8, 16, 32, 64…

if n = 2^a     ( a = biggest power of two can go into N)

W(n) = 1

pick a number 

77,  biggest power of 2 from 77 = 64

64 + 13 = 77,  biggest power of 2 from 13 = 8

same thing from the rest of numbers

8 + 5 = 13,  5 ⇒ 4

4+1 ⇒ 1

77 = 64 + 8 + 4 + 1

77 = 2^6 + 2^3 + 2^2 + 2^0


to binary


2^6   2^5   2^4   2^3   2^2   2^1   2^0

   1        0         0        1         1        0         1
   

77 = 64 + 13

= 64  +  13

= 2^a + r                              r, remaining part

13 =  8   +   5

= 2^a    +   r

1,  2,  3,  4,  5,  6,  7,  8,  9,  10,  11,  12,  13

1,  ~~2~~,  3,  ~~4~~,  5,  ~~6~~,  7,  ~~8~~,  9,  ~~10~~,  11,  12,  13

so, we just dropped (r) people which is 5

and it is 11’s turn.

11,  12,  13,  1,  3,  5,  7,  9     and it’s 8 people which is power of 2.

therfore, 11 is going to be the one who survive the last. (who ever starts)


if n  = 2^a + r   where  r < 2a

Then    w(n) = 2r + 1

plug it in…

if 13  = 8 + 5   where 5 < 2(3)=6

Then   10 + 1  = w(n) which is 11.


N = number of poeple

2^a + r

W(N) = Winner of people   == 2r+1



| Number Of People ( N ) | 2^a + r | Last Man Standing ( W )W(n) = 2r + 1 |
| --- | --- | --- |
| 1 | 1+0 | 2*0+1 = 1 |
| 2 | 2+0 | 2*0+1 = 1 |
| 3 | 2+1 | 2*1+1 = 3 |
| 4 | 4+0 | 2*0+1 = 1 |
| 5 | 4+1 | 2*1+1 = 3 |
| 6 | 4+2 | 2*2+1 = 5 |
| 7 | 4+3 | 2*3+1 = 7 |
| 8 | 8+0 | 2*0+1 = 1 |
| 9 | 8+1 | 2*1+1 = 3 |
| 10 | 8+2 | 2*2+1 = 5 |
| 11 | 8+3 | 2*3+1 = 7 |
| 12 | 8+4 | 2*4+1 = 9 |
| 13 | 8+5 | 2*5+1 = 11 |
| 14 | 8+6 | 2*6+1 = 13 |
| 41 | 32 + 9 | 2*9+1 = 19 |



Thus, Let’s try 41

41 = 2^a + r

a is  the greatest number to be power of 2 that can go in to the N=41

32 is the 2^a ⇒ 2, 4, 8, 16, 32  ⇒ a == 5

41 = 2^5 + r

41 - 32 = 9

2r + 1

= 2(9) + 1 = 19

19 will be the last man standing ro winner


Interpret to binary notation

N=41 

= 2^5 + 2^3 + 2^0

= 2^5, 2^4, 2^3, 2^2, 2^1, 2^0

=    1       0        1      0        0       1

move winning digit to the end ⇒ scoot one in for rest of numbers

=    0      1        0       0        1       1

    2^5, 2^4, 2^3, 2^2, 2^1, 2^0
    
= 2^4 + 2^1 + 2^0 

= 16    +   2    +  1

= 19

writing this in binary code would make the quiz much easier

r = 19

   = 1 0 1 0 0 1   ,    move 1st one to the end
   
   = 0 1 0 0 1 1
   
W(n) = 0 1 0 0 1 1


Let’s test another number 


96


2, 4, 8, 16, 32, 64, 

64 = 2^a ⇒   a = 6

96 - 64 = 32

r = 32

2(r) + 1

2(32) + 1 = 65


Try this in binary notation


32 = 2^5

2^6  2^5  2^4  2^3  2^2  2^1  2^0

   1       1        0        0       0       0      0   
   
   1       0       0        0        0      0       1
   

