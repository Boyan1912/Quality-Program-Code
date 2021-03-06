﻿# Mediator

Шаблонът за дизайн Mediator дефинира обект, който определя взаимовръзките между различните компоненти на системата.
Обикновено една програма (система) се състои от голям брой класове, измежду които е разпределена логиката
по работата на програмата. Когато обаче тези класове се развиват или се добавят нови (обикновено при поддръжка
или рефактуриране), комуникацията между тези класове може да стане прекалено сложна. Това прави програмата
трудна за разбиране и поддръжка, освен това самите класове стават взаимозависими един от друг.
Чрез Mediator-а комуникацията между класовете се енкапсулира в един отделен обект (mediator). Така обектите
вече не комуникират директо, а чрез посредник. Това намалява взаимозависимостта и намалява т. нар. "coupling".