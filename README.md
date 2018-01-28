# NumericalCases
Тестовое задание - склонение чисел

Напишите функцию преобразованию целого числа в строку прописью. В любом падеже и в любом роде. Прототип функции: 

`string `_`sumProp`_`(int `_`nSum`_`, string `_`sGender`_`, string `_`sCase`_`)`

_`nSum`_ - целое число менее триллиона (максимум 999 999 999 999)  
_`sGender`_ - род (&quot;М&quot;-мужской, &quot;Ж&quot;-женский, &quot;С&quot;-средний)  
_`sCase`_ - падеж (&quot;И&quot;-именительный, …, &quot;П&quot;-предложный)  
  

---
| Пример вызова функции                         | Результат                                                                 |
| --------------------------------------------- |---------------------------------------------------------------------------|
| sumProp(31, &quot;М&quot;, &quot;Р&quot;)     | &quot;тридцати одного&quot;                                               |
| sumProp(22, &quot;С&quot;, &quot;Т&quot;)     | &quot;двадцатью двумя&quot;                                               |
| sumProp(154323, &quot;М&quot;, &quot;И&quot;) | &quot;сто пятьдесят четыре тысячи триста двадцать три&quot;               |
| sumProp(154323, &quot;М&quot;, &quot;Т&quot;) | &quot;ста пятьюдесятью четырьмя тысячами тремястами двадцатью тремя&quot; |
 
