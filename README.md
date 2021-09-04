# app-config

Sample app showing how to download configuration from AWS AppConfig.

## Setup

### Prerequisites

* .NET Core SDK 3.1
* Powershell Core

## Solution structure

### LambdaAppConfig

This app shows how to use AppConfig in AWS Lambda.

#### Required variables to be set - deploy.ps1

* \[s3-bucket-name\] -> name of the Amazon S3 Bucket used to deploy AWS CloudFormation stacks.

#### Deployment

```powershell
deploy.ps1
```