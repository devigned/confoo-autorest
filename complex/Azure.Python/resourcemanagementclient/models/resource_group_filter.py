# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.serialization import Model


class ResourceGroupFilter(Model):
    """Resource group filter.

    :param tag_name: The tag name.
    :type tag_name: str
    :param tag_value: The tag value.
    :type tag_value: str
    """ 

    _attribute_map = {
        'tag_name': {'key': 'tagName', 'type': 'str'},
        'tag_value': {'key': 'tagValue', 'type': 'str'},
    }

    def __init__(self, tag_name=None, tag_value=None):
        self.tag_name = tag_name
        self.tag_value = tag_value
