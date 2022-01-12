# AppleStoreServerApi

Utility to decode and verify Apple server to server in app purchase notification and request Apple store api.

This library is already working but work is still in progress. Don't hesitate to contribute if you see any possible improvment or fixes.

I mainly based my work on this node library: https://raw.githubusercontent.com/agisboye/app-store-server-api

## Features
- History, subscription status and order lookup endpoints
- Typed responses (i.e. you get auto-complete for the fields in the response)
- Manages authentication tokens for you
- Helpers to decode JWS items
- Performs certificate validation against Apple's CA.
- Types and helpers for [App Store Server Notifications V2](https://developer.apple.com/documentation/appstoreservernotifications)

## Usage
### Prerequisites
To get started, you must obtain the following:
- An [API key](https://developer.apple.com/documentation/appstoreserverapi/creating_api_keys_to_use_with_the_app_store_server_api)
- The ID of the key
- Your [issuer ID](https://developer.apple.com/documentation/appstoreserverapi/generating_tokens_for_api_requests)

A note on the issuer ID:
Apple's documentation currently has incorrect instructions on how to obtain this.
To get your issuer ID, you must [create an API key for App Store Connect](https://developer.apple.com/documentation/appstoreconnectapi/creating_api_keys_for_app_store_connect_api) (not the App Store Server API). Only after creating your first API key will the issuer ID appear.

### Create a client
```
var PRIVATE_KEY = 
`-----BEGIN PRIVATE KEY-----
MHcCAQEEIPWH5lyoG7Wbzv71ntF6jNvFwwJLKYmPWN/KBD4qJfMcoAoGCCqGSM49
AwEHoUQDQgAEMOlUa/hmyAPU/RUBds6xzDO8QNrTFhFwzm8E4wxDnSAx8R9WOMnD
cVGdtnbLFIdLk8g4S7oAfV/gGILKuc+Vqw==
-----END PRIVATE KEY-----`

var KEY_ID = "ABCD123456"
var ISSUER_ID = "91fa5999-7b54-4363-a2a8-265363fa6cbe"
var APP_BUNDLE_ID = "com.yourcompany.app"

var client = new AppleAppstoreClient(
  PRIVATE_KEY, KEY_ID, ISSUER_ID, APP_BUNDLE_ID, environment: AppleEnvironment.Production
)
```