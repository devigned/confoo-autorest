/*
 * Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

/**
 * @class
 * Initializes a new instance of the TargetResource class.
 * @constructor
 * Target resource.
 *
 * @member {string} [id] The ID of the resource.
 * 
 * @member {string} [resourceName] The name of the resource.
 * 
 * @member {string} [resourceType] The type of the resource.
 * 
 */
function TargetResource() {
}

/**
 * Defines the metadata of TargetResource
 *
 * @returns {object} metadata of TargetResource
 *
 */
TargetResource.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'TargetResource',
    type: {
      name: 'Composite',
      className: 'TargetResource',
      modelProperties: {
        id: {
          required: false,
          serializedName: 'id',
          type: {
            name: 'String'
          }
        },
        resourceName: {
          required: false,
          serializedName: 'resourceName',
          type: {
            name: 'String'
          }
        },
        resourceType: {
          required: false,
          serializedName: 'resourceType',
          type: {
            name: 'String'
          }
        }
      }
    }
  };
};

module.exports = TargetResource;