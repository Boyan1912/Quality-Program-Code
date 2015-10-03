﻿# Facade pattern

Шаблонът за дизайн "Фасада" се използва, когато дадена система е прекалено сложна за разбиране сама по себе си, защото
съдържа много класове или пък сорс кода не е публичен. Целта на фасадата е да скрие сложността от клиента като му 
предостави лесни за използване набор от инструменти, които работят директно със сложния код зад фасадата. По този
начин шаблонът фасада не само прави употребата на чужда библиотека много по-лесна но и намалява зависимостта на програмата
от външен код, което прави възможно развитието на програмата да бъде по-гъвкаво и лесно за промяна или добавяне на
функционалности. Типичен пример за шаблонът "Фасада" са външните библиотеки от програмен код - например jquery за javascript.
Обикновено се състои от един единствен обект - "wrapper" ($ - jquery), който съдържа нужните за клиента функционалности.
Освен при използването на чужди библиотеки, фасадата може да се приложи и когато искаме да пододбрим лошо написано приложение.
Тогава просто скриваме лошият код зад добре написан такъв (фасада).
