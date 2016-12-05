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
 * Initializes a new instance of the TagDetails class.
 * @constructor
 * Tag details.
 *
 * @member {string} [id] The tag ID.
 * 
 * @member {string} [tagName] The tag name.
 * 
 * @member {object} [count] The total number of resources that use the
 * resource tag. When a tag is initially created and has no associated
 * resources, the value is 0.
 * 
 * @member {string} [count.type] Type of count.
 * 
 * @member {string} [count.value] Value of count.
 * 
 * @member {array} [values] The list of tag values.
 * 
 */
function TagDetails() {
}

/**
 * Defines the metadata of TagDetails
 *
 * @returns {object} metadata of TagDetails
 *
 */
TagDetails.prototype.mapper = function () {
  return {
    required: false,
    serializedName: 'TagDetails',
    type: {
      name: 'Composite',
      className: 'TagDetails',
      modelProperties: {
        id: {
          required: false,
          serializedName: 'id',
          type: {
            name: 'String'
          }
        },
        tagName: {
          required: false,
          serializedName: 'tagName',
          type: {
            name: 'String'
          }
        },
        count: {
          required: false,
          serializedName: 'count',
          type: {
            name: 'Composite',
            className: 'TagCount'
          }
        },
        values: {
          required: false,
          serializedName: 'values',
          type: {
            name: 'Sequence',
            element: {
                required: false,
                serializedName: 'TagValueElementType',
                type: {
                  name: 'Composite',
                  className: 'TagValue'
                }
            }
          }
        }
      }
    }
  };
};

module.exports = TagDetails;
