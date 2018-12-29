import sys
from pyquery import PyQuery as pq


def get_exchange_rates():
    doc = pq("https://rate.bot.com.tw/xrt?Lang=zh-TW")
    date_time = doc(".time").text()

    rate_content_cash_elements = doc("td.rate-content-cash")
    cash_rates = []
    for index, item in enumerate(rate_content_cash_elements.items()):
        if index % 2 == 0:
            cash_rate = {}
            cash_rate["buy"] = item.text()
        else:
            cash_rate["sell"] = item.text()
            cash_rates.append(cash_rate)

    rate_content_sight_elements = doc("td.rate-content-sight")
    sight_rates = []
    for index, item in enumerate(rate_content_sight_elements.items()):
        if index % 2 == 0:
            sight_rate = {}
            sight_rate["buy"] = item.text()
        else:
            sight_rate["sell"] = item.text()
            sight_rates.append(sight_rate)

    currencies = list(map(lambda item: item.text()
                          [-4:-1], doc("td div.visible-phone").items()))

    exchange_rates = {}

    for index, currency in enumerate(currencies):
        exchange_rate = {
            "currency": currency,
            "cash": cash_rates[index],
            "sight": sight_rates[index],
            "date_time": date_time
        }

        exchange_rates[currency] = exchange_rate

    return exchange_rates


print(get_exchange_rates())
