1) Создаем массив с данными, в которых будем искать слова с 3 и меньше символами 
2) Далее создаем цикл, с помощью которого пройдемся по массиву и найдем количество нужных слов. Начнем с 0 элемента массива, закончим последним (который находится на позиции длины массива). 
3) Заполняем цикл для поиска. Если "i" элемент массива имеет длину меньше 4 (то есть 3 и меньше), меняем флаг, который мы инициировали ранее, на тру. Далее если флаг у нас тру, выводим элемент массива и переходим к следующему.
4) Нашли количество слов. Теперь это количество используем для создания нового массива, куда мы и помещаем все найденные слова.
5) После показываем новый созданный массив со словами, которые состоят из 3 и меньше символов.