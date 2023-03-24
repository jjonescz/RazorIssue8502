https://github.com/dotnet/razor/issues/8502

```ps1
dotnet run
```

```ps1
curl http://localhost:5180
```

```html
<table>
<tbody>
    <tr id="line-item-0" class="sale-line-items" data-index="0">
        <td>
            <span>1</span>
        </td>
        <td>
            <input id="line-item-productSku-0" class="form-control" value="" data-index="0" value="sku1" />
            <input id="line-item-productId-0" name="Items[0].ProductId" type="hidden" value="123" />
            <input id="line-item-id-0" type="hidden" name="Items[0].Id" value="456" />
        </td>
        <td id="line-item-description-0">My product 1</td>
        <td>
            <input id="line-item-quantity-0"
                   class="form-control"
                   value=""
                   type="number"
                   name="Items[0].Quantity" />
        </td>
        <td class="item-box" style="text-align:right;">
            <span id="line-item-list-price-0" data-value="42">$42.00</span><br />
            <span id="line-item-disc-price-0" data-value="42.00" style="display:none;"></span>
        </td>
        <td id="line-item-subtotal-0" style="text-align:right;"></td>
    </tr>
    <tr id="line-item-1" class="sale-line-items" data-index="1">
        <td>
            <span>2</span>
        </td>
        <td>
            <input id="line-item-productSku-1" class="form-control" value="" data-index="1" value="sku2" />
            <input id="line-item-productId-1" name="Items[1].ProductId" type="hidden" value="124" />
            <input id="line-item-id-1" type="hidden" name="Items[1].Id" value="457" />
        </td>
        <td id="line-item-description-1">My product 2</td>
        <td>
            <input id="line-item-quantity-1"
                   class="form-control"
                   value="1"
                   type="number"
                   name="Items[1].Quantity" />
        </td>
        <td class="item-box" style="text-align:right;">
            <span id="line-item-list-price-1" data-value="43">$43.00</span><br />
            <span id="line-item-disc-price-1" data-value="40.85" style="display:none;"></span>
        </td>
        <td id="line-item-subtotal-1" style="text-align:right;"></td>
    </tr>
</tbody>
</table>
```
