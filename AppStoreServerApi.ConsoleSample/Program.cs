// See https://aka.ms/new-console-template for more information
using AppStoreServerApi;
using AppStoreServerApi.Models;

var PRIVATE_KEY = @"-----BEGIN PRIVATE KEY-----
MHcCAQEEIPWH5lyoG7Wbzv71ntF6jNvFwwJLKYmPWN/KBD4qJfMcoAoGCCqGSM49
AwEHoUQDQgAEMOlUa/hmyAPU/RUBds6xzDO8QNrTFhFwzm8E4wxDnSAx8R9WOMnD
cVGdtnbLFIdLk8g4S7oAfV/gGILKuc+Vqw==
-----END PRIVATE KEY-----";

var KEY_ID = "ABCD123456";
var ISSUER_ID = "91fa5999-7b54-4363-a2a8-265363fa6cbe";
var APP_BUNDLE_ID = "com.yourcompany.app";

var client = new AppleAppstoreClient(
  PRIVATE_KEY, KEY_ID, ISSUER_ID, APP_BUNDLE_ID, environment: AppleEnvironment.Production
);

var result = await client.GetSubscriptionStatuses("1000000945357845");