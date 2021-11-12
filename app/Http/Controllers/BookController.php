<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Models\Book;
use Illuminate\Support\Facades\Storage;

class BookController extends Controller
{
    public function index()
    {
        $books = Book::latest()->when(request()->search, function($books) {
            $books = $books->where('title', 'like', '%'. request()->search . '%');
        })->paginate(5);

        return view('book.index', compact('books'));
    }

    public function create()
{
  return view('book.create');
}

public function store(Request $request)
{
  $this->validate($request, [
    'title'     => 'required',
    'author'   => 'required',
    'publisher'  => 'required',
     'image'     => 'required|image|mimes:png,jpg,jpeg'
     
  ]);

  //upload image
  $image = $request->file('image');
  $image->storeAs('public/books', $image->hashName());

  $book = Book::create([
    'title'     => $request->title,
    'author'   => $request->author,
    'publisher'   => $request->publisher,
      'image'     => $image->hashName()
     
  ]);

  if($book){
    //redirect dengan pesan sukses
    return redirect()->route('book.index')->with(['success' => 'Data Berhasil Disimpan!']);
  }else{
    //redirect dengan pesan error
    return redirect()->route('book.index')->with(['error' => 'Data Gagal Disimpan!']);
  }

}

public function edit(Book $book)
{
  return view('book.edit', compact('book'));
}

public function update(Request $request, Book $book)
{
  $this->validate($request, [
      'title'     => 'required',
      'author'   => 'required',
      'publisher'   => 'required'

  ]);
    
  //get data book by ID
  $book = Book::findOrFail($book->id);
    
  if($request->file('image') == "") {
    
     $book->update([
         'title'     => $request->title,
         'author'   => $request->author,
         'publisher'   => $request->publisher
     ]);
    
  } else {
    
      //hapus old image
      Storage::disk('local')->delete('public/books/'.$book->image);
    
      //upload new image
      $image = $request->file('image');
      $image->storeAs('public/books', $image->hashName());
    
      $book->update([
         
         'title'     => $request->title,
         'author'   => $request->author,
         'publisher'   => $request->publisher,
         'image'     => $image->hashName()
      ]);
    
  }
    
  if($book){
     //redirect dengan pesan sukses
     return redirect()->route('book.index')->with(['success' => 'Data Berhasil Diupdate!']);
  }else{
     //redirect dengan pesan error
     return redirect()->route('book.index')->with(['error' => 'Data Gagal Diupdate!']);
  }
}
public function destroy($id)
{
  $book = Book::findOrFail($id);
  Storage::disk('local')->delete('public/books/'.$book->image);
  $book->delete();

  if($book){
    //redirect dengan pesan sukses
    return redirect()->route('book.index')->with(['success' => 'Data Berhasil Dihapus!']);
  }else{
    //redirect dengan pesan error
    return redirect()->route('book.index')->with(['error' => 'Data Gagal Dihapus!']);
  }
}
}
