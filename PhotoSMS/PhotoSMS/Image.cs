using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoSMS
{
    class Image
    {

        string name;
        string date;
        string tags;
        string link;
        float size;

        void setName(string name) { this.name = name; }
        string getName() { return this.name; }

        void setDate(string dat) { this.date = dat; }
        string getDate() { return this.date; }

        void setTags(string tag) { this.tags = tag; }
        string getTags() { return this.tags; }

        void setLink(string lin) { this.link = lin; }
        string getLink() { return this.link; }

        void setSize(float siz) { this.size = siz; }
        float getSize() { return this.size; }


    }
}
