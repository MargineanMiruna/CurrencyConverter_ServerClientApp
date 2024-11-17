import socket
import freecurrencyapi

apikey = 'fca_live_yyyrueTw2eBuFnfz1YFXKzV2GilKO5aIaXZh9vQi'


def get_exchange_rate(base, target):
    info = freecurrencyapi.Client(apikey)
    result = info.latest(base)
    return result['data'][target]


def start_server():
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.bind(("0.0.0.0", 7890))
    s.listen(5)
    print("Listening...")
    while True:
        cs, addr = s.accept()
        print(f"Connection from {addr}")

        try:
            buf = cs.recv(1024).decode()
            if buf:
                print("Received data...")
                base_currency = buf[0:3]
                target_currency = buf[4:7]

                rate = get_exchange_rate(base_currency,target_currency)
                amount = float(buf[8:])
                target = amount * rate
                cs.send(str.encode(str(target)))
        finally:
            cs.close()
            print(f"Connection with {addr} closed.")


start_server()
