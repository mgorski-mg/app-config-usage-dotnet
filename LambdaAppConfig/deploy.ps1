dotnet lambda deploy-serverless `
    --configuration Release `
    --region eu-west-1 `
    --stack-name app-config-lambda `
    --s3-bucket [s3-bucket-name] `
    --s3-prefix app-config-sample/lambda/ `
    --template application.yaml `
    --tags "service-name=app-config-lambda";