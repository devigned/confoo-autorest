/*
 * Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

var models = require('./index');

/**
 * @class
 * Initializes a new instance of the DeploymentOperation class.
 * @constructor
 * Deployment operation information.
 *
 * @member {string} [id] Full deployment operation ID.
 * 
 * @member {string} [operationId] Deployment operation ID.
 * 
 * @member {object} [properties] Deployment properties.
 * 
 * @member {string} [properties.provisioningState] The state of the
 * provisioning.
 * 
 * @member {date} [properties.timestamp] The date and time of the operation.
 * 
 * @member {string} [properties.serviceRequestId] Deployment operation service
 * request id.
 * 
 * @member {string} [properties.statusCode] Operation status code.
 * 
 * @member {object} [properties.statusMessage] Operation status message.
 * 
 * @member {object} [properties.targetResource] The target resource.
 * 
 * @member {string} [properties.targetResource.id] The ID of the resource.
 * 
 * @member {string} [properties.targetResource.resourceName] The name of the
 * resource.
 * 
 * @member {string} [properties.targetResource.resourceType] The type of the
 * resource.
 * 
 * @member {object} [properties.request] The HTTP request message.
 * 
 * @member {object} [properties.request.content] HTTP message content.
 * 
 * @member {object} [properties.response] The HTTP response message.
 * 
 * @member {object} [properties.response.content] HTTP message content.
 * 
 */
function DeploymentOperation() {
}

/**
 * Defines the metadata of DeploymentOperation
 *
 * @returns {object} metadata of DeploymentOperation
 *
 */
DeploymentOperation.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'DeploymentOperation',
    type: {
      name: 'Composite',
      className: 'DeploymentOperation',
      modelProperties: {
        id: {
          required: false,
          readOnly: true,
          serializedName: 'id',
          type: {
            name: 'String'
          }
        },
        operationId: {
          required: false,
          readOnly: true,
          serializedName: 'operationId',
          type: {
            name: 'String'
          }
        },
        properties: {
          required: false,
          serializedName: 'properties',
          type: {
            name: 'Composite',
            className: 'DeploymentOperationProperties'
          }
        }
      }
    }
  };
};

module.exports = DeploymentOperation;
