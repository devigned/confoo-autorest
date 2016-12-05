# coding=utf-8
# --------------------------------------------------------------------------
# Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
# Changes may cause incorrect behavior and will be lost if the code is
# regenerated.
# --------------------------------------------------------------------------

from msrest.paging import Paged


class TagDetailsPaged(Paged):
    """
    A paging container for iterating over a list of TagDetails object
    """

    _attribute_map = {
        'next_link': {'key': 'nextLink', 'type': 'str'},
        'current_page': {'key': 'value', 'type': '[TagDetails]'}
    }

    def __init__(self, *args, **kwargs):

        super(TagDetailsPaged, self).__init__(*args, **kwargs)
