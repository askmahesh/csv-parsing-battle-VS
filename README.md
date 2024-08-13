# CSV File Processing Benchmark:  Golang vs NestJS vs PHP vs Python
This repository contains scripts to benchmark the performance of Golang, NestJS, PHP, and Python  in processing large CSV files. The benchmark compares the execution time, memory usage, and ease of implementation for each language.

## Introduction
Processing large CSV files efficiently is a common requirement in many applications, from data analysis to ETL (Extract, Transform, Load) processes. This repository benchmarks the performance of three popular programming languages—Golang, NestJS, PHP, and Python—in handling large CSV files.

## Test Environment
- Golang 1.22.x
- Node.js 22.x with NestJS
- PHP 8.3.x
- Python 3.12.x
- Java
- C#
- VB.Net
## Project Tree
 * [generate-csv](./generate-csv)
   * [generate_csv.go](./generate-csv/generate_csv.go)
 * [read-csv-go](./read-csv-go)
   * [sales.go](./read-csv-go/sales.go)
 * [read-csv-nestjs](./read-csv-nestjs)
   * [src](./read-nestjs/src)
     * [csv](./read-nestjs/src.csv)
       * [csv.controller.ts](./read-nestjs/src/csv/csv.controller.ts)
       * [csv.service.ts](./read-nestjs/src/csv/csv.service.ts)
       * ...
     * ...
   * ...
 * [read-csv-php](./read-csv-php)
   * [sales.php](./read-csv-php/sales.php)
 * [read-csv-python](./read-csv-python)
   * [sales.py](./read-csv-python/sales.py)
 * [.gitignore](./.gitignore)
 * [LICENSE](./LICENSE)
 * [README.md](./README.md)

## Setup

### Test Data
We used a synthetic CSV file named sales_data.csv with approximately 1 million rows, each containing transaction details such as transaction_id, product_id, quantity, price, and timestamp.

```csv
transaction_id,product_id,quantity,price,timestamp
1,1001,2,19.99,2023-07-01 12:34:56
2,1002,1,99.99,2023-07-01 12:45:00
...
```
Run the Go Script

```go
cd generate-csv
```
```go
go run generate_csv.go
```

### Read CSV Go
Run the Go Script

```go
cd read-csv-go
```
```go
go run sales.go
```

Running the Benchmarks
```go
time go run sales.go
```

### Read CSV NestJS
Install NPM

```npm
cd read-csv-nestjs
```
```npm
npm install
```
Build & run the project

```npm
npm run build
```
```npm
node dist/main.js
```

Running the Benchmarks
```npm
time node dist/main.js
```

### Read CSV PHP
Run the PHP Script
```php
cd read-csv-php
```
```php
php sales.php
```
Running the Benchmarks
```php
time php sales.php
```
### Read CSV Python
Run the Python Script
```py
cd read-csv-python
```
```py
python sales.py #windows
#or
python3 sales.py #mac/linux
```
Running the Benchmarks
```py
time python sales.py #windows
#or
time python3 sales.py #mac/linux
```
### Read CSV VB
vbc Program.vb -out:VBProg.exe
VBProg.exe
Note: Input file in same directory


### Read CSV C#
csc Sales2.cs -out:Sales-cs.exe
Sales-cs.exe

Note: Input file in same directory

## Results
Here you should include the results of your benchmarks, such as execution time and any other relevant metrics.

### Golang
- Go Execution time: X.XX seconds
- Total Sales: $Y.YY
- Top Product: Product Z with sales $ZZ.ZZ

### NestJS
- NestJS Execution time: X.XX seconds
- Total Sales: $Y.YY
- Top Product: Product Z with sales $ZZ.ZZ

### PHP
- PHP Execution time: X.XX seconds
- Total Sales: $Y.YY
- Top Product: Product Z with sales $ZZ.ZZ

### Python
- Python Execution time: X.XX seconds
- Total Sales: $Y.YY
- Top Product: Product Z with sales $ZZ.ZZ

### Python


## License
This project is licensed under the MIT License - see the [LICENSE](./LICENSE)  file for details.

