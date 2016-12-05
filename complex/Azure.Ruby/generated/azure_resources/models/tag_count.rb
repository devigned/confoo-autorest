# encoding: utf-8
# Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.

module Azure
  module Models
    #
    # Tag count.
    #
    class TagCount

      include MsRestAzure

      # @return [String] Type of count.
      attr_accessor :type

      # @return [String] Value of count.
      attr_accessor :value


      #
      # Mapper for TagCount class as Ruby Hash.
      # This will be used for serialization/deserialization.
      #
      def self.mapper()
        {
          required: false,
          serialized_name: 'TagCount',
          type: {
            name: 'Composite',
            class_name: 'TagCount',
            model_properties: {
              type: {
                required: false,
                serialized_name: 'type',
                type: {
                  name: 'String'
                }
              },
              value: {
                required: false,
                serialized_name: 'value',
                type: {
                  name: 'String'
                }
              }
            }
          }
        }
      end
    end
  end
end
