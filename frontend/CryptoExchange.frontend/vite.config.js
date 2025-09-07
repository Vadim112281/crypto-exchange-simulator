import { defineConfig } from 'vite'
import react from '@vitejs/plugin-react-swc'

export default defineConfig({
    plugins: [react()],
    server: {
        port: 7166,
        proxy: {
            '/api': {
                target: 'https://localhost:7166',
                changeOrigin: true,
                secure: false,
            },
        },
    },
})
