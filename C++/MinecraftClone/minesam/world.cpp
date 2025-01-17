#include "world.h"


World::World(Vector3f* m_currentBlock, Vector3f* m_currentFaceNormal, Vector3f* m_posPrecedent, Player* player) :m_chunks((VIEW_DISTANCE * 2) / CHUNK_SIZE_X, (VIEW_DISTANCE * 2) / CHUNK_SIZE_Z)
{
   this->m_currentBlock = m_currentBlock;
   this->m_currentFaceNormal = m_currentFaceNormal;
   this->m_posPrecedent = m_posPrecedent;
   this->m_player = player;
}

World::~World()
= default;


Array2d<Chunk*> World::getChunks() const {
   return m_chunks;
}



void World::setChunks(int x, int y)
{
   m_chunks.Set(x, y, new Chunk(x, y));
}



void World::GetBlocAtCursor(int Width, int Height, bool m_click)
{
   int x = Width / 2;
   int y = Height / 2;

   GLint viewport[4];
   GLdouble modelview[16];
   GLdouble projection[16];
   GLfloat winX, winY, winZ;
   GLdouble posX, posY, posZ;

   glGetDoublev(GL_MODELVIEW_MATRIX, modelview);
   glGetDoublev(GL_PROJECTION_MATRIX, projection);
   glGetIntegerv(GL_VIEWPORT, viewport);

   winX = (float)x;
   winY = (float)viewport[3] - (float)y;
   glReadPixels(x, int(winY), 1, 1, GL_DEPTH_COMPONENT, GL_FLOAT, &winZ);

   gluUnProject(winX, winY, winZ, modelview, projection, viewport, &posX, &posY, &posZ);

   posX += .5f;
   posY += .5f;
   posZ += .5f;

   // Le cast vers int marche juste pour les valeurs entiere, utiliser une fonction de la libc si besoin
   // de valeurs negatives
   int px = (int)(posX);
   int py = (int)(posY);
   int pz = (int)(posZ);

   bool found = false;

   if ((m_player->Position() - Vector3f(posX, posY, posZ)).Length() < MAX_SELECTION_DISTANCE)
   {
      // Apres avoir determine la position du bloc en utilisant la partie entiere du hit
      // point retourne par opengl, on doit verifier de chaque cote du bloc trouve pour trouver
      // le vrai bloc. Le vrai bloc peut etre different a cause d'erreurs de precision de nos
      // nombres flottants (si z = 14.999 par exemple, et qu'il n'y a pas de blocs a la position
      // 14 (apres arrondi vers l'entier) on doit trouver et retourner le bloc en position 15 s'il existe
      // A cause des erreurs de precisions, ils arrive que le cote d'un bloc qui doit pourtant etre a la
      // position 15 par exemple nous retourne plutot la position 15.0001
      for (int x = px - 1; !found && x <= px + 1; ++x)
      {
         for (int y = py - 1; !found && x >= 0 && y <= py + 1; ++y)
         {
            for (int z = pz - 1; !found && y >= 0 && z <= pz + 1; ++z)
            {
               if (z >= 0)
               {
                  BlockType bt = BlockAt(x, y, z);
                  if (bt == BTYPE_AIR)
                     continue;

                  // Skip water blocs
                  //if(bloc->Type == BT_WATER)
                  //    continue;

                  m_currentBlock->x = x;
                  m_currentBlock->y = y;
                  m_currentBlock->z = z;


                  if (InRangeWithEpsilon<float>(posX, x, x + 1, 0.05) && InRangeWithEpsilon<float>(posY, y, y + 1, 0.05) && InRangeWithEpsilon<float>(posZ, z, z + 1, 0.05))
                  {
                     found = true;
                  }
               }
            }
         }
      }
   }

   if (!found)
   {
      m_currentBlock->x = -1;
   }
   else
   {
      // Find on which face of the bloc we got an hit
      m_currentFaceNormal->Zero();
      const float epsilon = 0.1f;
      // Front et back:
      if (EqualWithEpsilon<float>(posZ, m_currentBlock->z, epsilon))
         m_currentFaceNormal->z = -1;
      else if (EqualWithEpsilon<float>(posZ, m_currentBlock->z + 1, epsilon))
         m_currentFaceNormal->z = 1;
      else if (EqualWithEpsilon<float>(posX, m_currentBlock->x, epsilon))
         m_currentFaceNormal->x = -1;
      else if (EqualWithEpsilon<float>(posX, m_currentBlock->x + 1, epsilon))
         m_currentFaceNormal->x = 1;
      else if (EqualWithEpsilon<float>(posY, m_currentBlock->y, epsilon))
         m_currentFaceNormal->y = -1;
      else if (EqualWithEpsilon<float>(posY, m_currentBlock->y + 1, epsilon))
         m_currentFaceNormal->y = 1;
   }
   if (m_click == true)
   {
      Craft();
   }
}


void World::Craft()
{
   //arbre
   if (ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->GetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y) % 128, (int)m_currentBlock->z % 16) == BTYPE_CRAFT
      && ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->GetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, (int)m_currentBlock->z % 16) == BTYPE_GRASS)
   {
      for (int i = 0; i < 7; i++)
      {
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y + i) % 128, ((int)m_currentBlock->z) % 16, BTYPE_WOOD);
      }
      ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, ((int)m_currentBlock->z) % 16, BTYPE_DIRT);

      for (int h = 0; h < 4; h++)
      {
         for (int x1 = (m_currentBlock->x - 2) + h; x1 <= (m_currentBlock->x + 2) - h; x1++)
         {
            for (int z1 = (m_currentBlock->z - 2) + h; z1 <= (m_currentBlock->z + 2) - h; z1++)
            {
               for (int y1 = (m_currentBlock->y + 4); y1 <= (m_currentBlock->y + 4) + h; y1++)
               {
                  if (x1 != 0 && z1 != 0)
                  {
                     ChunkAt(x1, y1, z1)->SetBlock(x1 % 16, y1 % 128, z1 % 16, BTYPE_LEAF);
                  }
               }
            }

         }
      }
   }

   //obsidian
   if (ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->GetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y) % 128, (int)m_currentBlock->z % 16) == BTYPE_CRAFT
      && ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->GetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, (int)m_currentBlock->z % 16) == BTYPE_COBBLESTONE)
   {
      ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y) % 128, (int)m_currentBlock->z % 16, BTYPE_AIR);
      ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, (int)m_currentBlock->z % 16, BTYPE_OBSIDIAN);
   }

   //planks
   if (ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->GetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y) % 128, (int)m_currentBlock->z % 16) == BTYPE_CRAFT
      && ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->GetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, (int)m_currentBlock->z % 16) == BTYPE_WOOD)
   {
      ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y) % 128, (int)m_currentBlock->z % 16, BTYPE_AIR);
      if (m_currentBlock->x <= 13 && m_currentBlock->z <= 13)
      {
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, (int)m_currentBlock->z % 16, BTYPE_PLANK);
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x + 1) % 16, ((int)m_currentBlock->y - 1) % 128, (int)m_currentBlock->z % 16, BTYPE_PLANK);
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x + 1) % 16, ((int)m_currentBlock->y - 1) % 128, ((int)m_currentBlock->z + 1) % 16, BTYPE_PLANK);
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, ((int)m_currentBlock->z + 1) % 16, BTYPE_PLANK);
      }
      else
      {
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, (int)m_currentBlock->z % 16, BTYPE_PLANK);
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x - 1) % 16, ((int)m_currentBlock->y - 1) % 128, (int)m_currentBlock->z % 16, BTYPE_PLANK);
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x - 1) % 16, ((int)m_currentBlock->y - 1) % 128, ((int)m_currentBlock->z - 1) % 16, BTYPE_PLANK);
         ChunkAt(m_currentBlock->x, m_currentBlock->y, m_currentBlock->z)->SetBlock(((int)m_currentBlock->x) % 16, ((int)m_currentBlock->y - 1) % 128, ((int)m_currentBlock->z - 1) % 16, BTYPE_PLANK);
      }
   }
}

void World::AddBlockToMesh(VertexBuffer::VertexData* vd, int& count, BlockType bt, int x, int y, int z, float u, float v, float w)
{
   if(BlockAt(x+1,y,z)==BTYPE_AIR)
   {
      //droite
      vd[count++] = VertexBuffer::VertexData(x + .5f, y - .5f, z + .5f, .8f, .8f, .8f, u, v);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y - .5f, z - .5f, .8f, .8f, .8f, u + w, v);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y + .5f, z - .5f, .8f, .8f, .8f, u + w, v + w);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y + .5f, z + .5f, .8f, .8f, .8f, u, v + w);
   }
   if (y == CHUNK_SIZE_Y - 1 || (y != CHUNK_SIZE_Y - 1 && BlockAt(x, (y + 1), z) == BTYPE_AIR))
   {
      //dessus
      vd[count++] = VertexBuffer::VertexData(x - .5f, y + .5f, z + .5f, 1.f, 1.f, 1.f, u, v);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y + .5f, z + .5f, 1.f, 1.f, 1.f, u + w, v);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y + .5f, z - .5f, 1.f, 1.f, 1.f, u + w, v + w);
      vd[count++] = VertexBuffer::VertexData(x - .5f, y + .5f, z - .5f, 1.f, 1.f, 1.f, u, v + w);
   }
   if (BlockAt(x, y, z+1) == BTYPE_AIR)
   {
      // front
      vd[count++] = VertexBuffer::VertexData(x - .5f, y - .5f, z + .5f, .9f, .9f, .9f, u, v);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y - .5f, z + .5f, .9f, .9f, .9f, u + w, v);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y + .5f, z + .5f, .9f, .9f, .9f, u + w, v + w);
      vd[count++] = VertexBuffer::VertexData(x - .5f, y + .5f, z + .5f, .9f, .9f, .9f, u, v + w);
   }


   if (BlockAt(x - 1, y, z) == BTYPE_AIR)
   {
      //gauche
      vd[count++] = VertexBuffer::VertexData(x - .5f, y - .5f, z - .5f, .8f, .8f, .8f, u, v);
      vd[count++] = VertexBuffer::VertexData(x - .5f, y - .5f, z + .5f, .8f, .8f, .8f, u + w, v);
      vd[count++] = VertexBuffer::VertexData(x - .5f, y + .5f, z + .5f, .8f, .8f, .8f, u + w, v + w);
      vd[count++] = VertexBuffer::VertexData(x - .5f, y + .5f, z - .5f, .8f, .8f, .8f, u, v + w);
   }
   if ((y == 0) || (y != 0 && BlockAt(x, (y - 1), z) == BTYPE_AIR))
   {
      //dessous
      vd[count++] = VertexBuffer::VertexData(x - .5f, y - .5f, z - .5f, 1.f, 1.f, 1.f, u, v);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y - .5f, z - .5f, 1.f, 1.f, 1.f, u + w, v);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y - .5f, z + .5f, 1.f, 1.f, 1.f, u + w, v + w);
      vd[count++] = VertexBuffer::VertexData(x - .5f, y - .5f, z + .5f, 1.f, 1.f, 1.f, u, v + w);
   }
   if (BlockAt(x, y, z-1) == BTYPE_AIR)
   {
      //arri�re
      vd[count++] = VertexBuffer::VertexData(x + .5f, y - .5f, z - .5f, .9f, .9f, .9f, u, v);
      vd[count++] = VertexBuffer::VertexData(x - .5f, y - .5f, z - .5f, .9f, .9f, .9f, u + w, v);
      vd[count++] = VertexBuffer::VertexData(x - .5f, y + .5f, z - .5f, .9f, .9f, .9f, u + w, v + w);
      vd[count++] = VertexBuffer::VertexData(x + .5f, y + .5f, z - .5f, .9f, .9f, .9f, u, v + w);
   }
}

void World::Update(BlockInfo* blockinfo[], int x1, int z1)
{
   // Update mesh
   if (m_chunks.Get(x1, z1)->IsDirty())
   {
      int maxVertexCount = (CHUNK_SIZE_X * CHUNK_SIZE_Y * CHUNK_SIZE_Z) * (6 * 4);
      VertexBuffer::VertexData* vd = new VertexBuffer::VertexData[maxVertexCount];

      int count = 0;

      for (int x = 0; x < CHUNK_SIZE_X; ++x)
      {
         for (int z = 0; z < CHUNK_SIZE_Z; ++z)
         {
            for (int y = 0; y < CHUNK_SIZE_Y; ++y)
            {
               if (count > USHRT_MAX)
                  break;

               BlockType bt = m_chunks.Get(x1, z1)->GetBlock(x, y, z);

               if (bt != BTYPE_AIR)
               {
                  AddBlockToMesh(vd, count, bt, (x + x1 * CHUNK_SIZE_X), y, (z + z1 * CHUNK_SIZE_Z), blockinfo[bt]->GetU(), blockinfo[bt]->GetV(), blockinfo[bt]->GetW());
               }
            }
         }
      }
      if (count > USHRT_MAX)
      {
         count = USHRT_MAX;
         std::cout << "[ Chunk :: Update ] Chunk data truncaned , too much vertices to have a 16 bit index " << std::endl;
      }
      m_chunks.Get(x1, z1)->m_vertexBuffer.SetMeshData(vd, count);
      delete[] vd;
   }
   m_chunks.Get(x1, z1)->SetIsDirtyFalse();
}







