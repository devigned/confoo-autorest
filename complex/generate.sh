#! /bin/bash

languages=( "Azure.Ruby" "Azure.Python" "Azure.NodeJS" "Azure.CSharp")

for i in "${languages[@]}"
do
   : 
   ../bin/autorest -Input azure-resources.json -Namespace 'Azure' -CodeGenerator $i -OutputDirectory $i
done