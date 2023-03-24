```ps1
dotnet run
```

```ps1
curl 'http://localhost:5014/Home/AppendLineItems?startIndex=100&numberOfLines=1&discount=0'
```

```html
<table>
<tbody>
    <tr id="line-item-100" class="sale-line-items" data-index="100">
        <td>
            <span>101</span>
        </td>
        <td>
            <input id="line-item-productSku-100" class="form-control" value="" data-index="100" value="sku100" />
            <input id="line-item-productId-100" name="Items[100].ProductId" type="hidden" value="101" />
            <input id="line-item-id-100" type="hidden" name="Items[100].Id" value="101" />
        </td>
        <td id="line-item-description-100">My product 100</td>
        <td>
            <input id="line-item-quantity-100"
                   class="form-control"
                   value="100"
                   type="number"
                   name="Items[100].Quantity" />
        </td>
        <td class="item-box" style="text-align:right;">
            <span id="line-item-list-price-100" data-value="20">$20.00</span><br />
            <span id="line-item-disc-price-100" data-value="20.00" style="display:none;"></span>
        </td>
        <td id="line-item-subtotal-100" style="text-align:right;"></td>
    </tr>
</tbody>
</table>
```
