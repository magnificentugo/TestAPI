#!/bin/bash
echo "Building Docker image..."
docker build --no-cache -t magnificent/testapi:latest .

echo "Pushing image to Docker Hub..."
docker push magnificent/testapi:latest

echo "Current Kubernetes context: $(kubectl config current-context)"

echo "Updating Kubernetes deployment..."
kubectl set image deployment/testapi-deployment testapi=magnificent/testapi:latest --record

kubectl rollout restart deployment/testapi-deployment