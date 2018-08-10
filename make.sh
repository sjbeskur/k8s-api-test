#!/bin/bash

if [ -d target/ ]; then
    rm -rf target/
fi

mkdir target/

docker build -t k8sapi-build . -f build/Dockerfile
docker run -it --rm  -v $PWD/target:/target k8sapi-build

docker build -t k8sapi-test . -f build/Dockerfile.msft-dotnet