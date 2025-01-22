# Base image
FROM node:18-alpine

# Set working directory
WORKDIR /app

# Copy package files (package.json and package-lock.json)
COPY package.json /app/package.json

# Install dependencies
RUN npm install --legacy-peer-deps

# Copy the rest of the application files
COPY . .

# Expose the application port
EXPOSE 64125

# Start the application
CMD ["npm", "run", "dev", "--", "--host"]
