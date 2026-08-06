# Architecture V1

## Overview

Version 1 of the platform consists of a single ASP.NET Core Web API responsible for managing football teams, fixtures and league table calculations.

Persistence will initially be handled using in-memory data before PostgreSQL is introduced in a later phase.

## Architecture

Client
│
▼
Fixtures API
│
▼
In-Memory Data

## Responsibilities

The API is responsible for:

- Managing football teams
- Managing fixtures
- Recording fixture results
- Calculating the league table
- Validating business rules

## Future Evolution

As the project progresses the architecture will evolve to include:

- PostgreSQL
- Kafka
- Analytics Service
- Redis
- Identity Service
- API Gateway
- Kubernetes
- Azure

The objective is to introduce one architectural concern at a time while maintaining a working application throughout development.