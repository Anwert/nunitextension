Запуск сборки:

msbuild nunitsimpletest.sln

Запуск всех тестов:

mono nunit3-console.exe nunitsimpletest.sln

Запуск определенных тестов с доп. параметром:

mono nunit3-console.exe nunitsimpletest.sln --params:run_id=99 --where "class =~ TestClass1 && name == Test1"