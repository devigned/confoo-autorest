#! /bin/bash

languages=( "Ruby" "Python" "NodeJS" "CSharp")

for i in "${languages[@]}"
do
   : 
   ../bin/autorest -Input helloworld.json -Namespace 'HelloWorld' -CodeGenerator $i -OutputDirectory $i
done