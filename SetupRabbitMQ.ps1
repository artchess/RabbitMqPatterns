param([String]$RabbitDllPath = "not specified")

$RabbitDllPath = Resolve-Path $RabbitDllPath 
Write-Host "Rabbit DLL Path: " 
Write-Host $RabbitDllPath -foregroundcolor green

#Set-ExecutionPolicy Unrestricted

$absoluteRabbitDllPath = Resolve-Path $RabbitDllPath

Write-Host "Absolute Rabbit DLL Path: " 
Write-Host $absoluteRabbitDllPath -foregroundcolor green

[Reflection.Assembly]::LoadFile($absoluteRabbitDllPath)

Write-Host "Setting up RabbitMQ Connection Factory"
$factory = new-object RabbitMQ.Client.ConnectionFactory
$factory.HostName = "localhost"
$factory.UserName = "guest"
$factory.Password = "guest"

$createConnectionMethod = [RabbitMQ.Client.ConnectionFactory].GetMethod(“CreateConnection”, [Type]::EmptyTypes)
$connection = $createConnectionMethod.Invoke($factory, “instance,public”, $null, $null, $null)

Write-Host "Setting up RabbitMQ Model"
$model = $connection.CreateModel()

Write-Host "Creating Exchange1"
$exchangeType = [RabbitMQ.Client.ExchangeType]::Fanout

$model.ExchangeDeclare("Exchange1", $exchangeType, $true, $false, $null)

Write-Host "Creating Server3 Queue4"
$model.QueueDeclare(“Queue4”, $true, $false, $false, $null)
$model.QueueBind("Queue4", "Exchange1", "", $null)


Write-Host "Creating Server4 Queue5"
$model.QueueDeclare(“Queue5”, $true, $false, $false, $null)
$model.QueueBind("Queue5", "Exchange1", "", $null)

Write-Host "Setup complete"