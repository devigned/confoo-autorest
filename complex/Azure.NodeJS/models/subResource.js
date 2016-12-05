/*
 * Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
 * Changes may cause incorrect behavior and will be lost if the code is
 * regenerated.
 */

'use strict';

var models = require('./index');

var util = require('util');

/**
 * @class
 * Initializes a new instance of the SubResource class.
 * @constructor
 * @member {string} [id] Resource ID
 * 
 */
function SubResource() {
  SubResource['super_'].call(this);
}

util.inherits(SubResource, models['BaseResource']);

/**
 * Defines the metadata of SubResource
 *
 * @returns {object} metadata of SubResource
 *
 */
SubResource.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'SubResource',
    type: {
      name: 'Composite',
      className: 'SubResource',
      modelProperties: {
        id: {
          required: false,
          serializedName: 'id',
          type: {
            name: 'String'
          }
        }
      }
    }
  };
};

module.exports = SubResource;
