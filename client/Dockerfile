WORKDIR /app
COPY / ./
COPY package*.json ./

RUN npm install -g @angular/cli@12.2.12 && \
    npm install && \
    ng build
COPY . .

FROM nginx:1.17.1-alpine
WORKDIR /app
COPY --from=build /app/dist/ui /usr/share/nginx/html