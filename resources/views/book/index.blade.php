@extends('layouts.bookapp', ['title' => 'Data Books'])

@section('content')

<div class="container mx-auto mt-10 mb-10">
    <div class="bg-white p-5 rounded shadow-sm">
        <div class="grid grid-cols-8 gap-4 mb-4">
        <div class="col-span-7">
                <form action="{{ route('book.index') }}" method="GET">
                    <input type="text" name="search"
                    class="w-full bg-gray-200 p-2 rounded shadow-sm border border-gray-200 focus:outline-none focus:bg-white"
                    placeholder="ketik judul Buku setelah itu enter ok!">
                </form>
            </div>
            <div class="col-span-1 mt-2">
                <a href="{{ route('book.create') }}"
                    class="w-full bg-red-500 text-white p-3 rounded shadow-sm focus:outline-none hover:bg-red-900">TAMBAH
                    BOOK</a>
            </div>
           
        </div>
        <table class="min-w-full table-auto">
            <thead class="justify-between">
                <tr class="bg-green-500 w-full">
                    <th class="px-16 py-2">
                        <span class="text-white">TITLE</span>
                    </th>
                    <th class="px-16 py-2 text-left">
                        <span class="text-white">AUTHOR</span>
                    </th>
                    <th class="px-16 py-2 text-left">
                        <span class="text-white">PUBLISHER</span>
                    </th>
                    <th class="px-16 py-2 text-left">
                        <span class="text-white">IMAGE</span>
                    </th>
                    <th class="px-16 py-2">
                        <span class="text-white">AKSI</span>
                    </th>
                </tr>
            </thead>
            <tbody class="bg-gray-200">
                @forelse($books as $book)
                    <tr class="bg-white border-2 border-gray-200">

                       
                        <td class="px-16 py-2">
                            {{ $book->title }}
                        </td>
                        <td class="px-16 py-2">
                            {!! $book->author !!}
                        </td>
                        <td class="px-16 py-2">
                            {!! $book->publisher !!}
                        </td>
                        <td class="px-16 py-2">
                            <img src="{{ Storage::url('public/books/'.$book->image) }}" class="w-48 rounded-md">
                        </td>
                        <td class="px-10 py-2 text-center">
                        <form onsubmit="return confirm('Apakah Anda Yakin mau dihapus ?');" action="{{ route('book.destroy', $book->id) }}" method="POST">
                                <button class="bg-green-500 text-white px-4 py-2 rounded hover:border-green-900 text-xs focus:outline-none mr-2"><a href="{{ route('book.edit', $book->id) }}">EDIT</a></button>
                                    @csrf
                                    @method('DELETE')
                                <button type="submit" class="bg-red-500 text-white px-4 py-2 rounded hover:border-red-700 text-xs focus:outline-none"> HAPUS</button>
                            </form>
                        </td>
                    </tr>
                @empty
                    <div class="bg-red-500 text-white p-3 rounded shadow-sm mb-3">
                        Data Belum Tersedia!
                    </div>
                @endforelse
            </tbody>
        </table>
        <div class="mt-2">
            {{ $books->links('vendor.pagination.tailwind') }}
        </div>
    </div>
</div>

@endsection