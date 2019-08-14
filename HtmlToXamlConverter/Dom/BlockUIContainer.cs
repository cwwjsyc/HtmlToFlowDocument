﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HtmlToFlowDocument.Dom
{
  public class BlockUIContainer : Block
  {

    protected override void ThrowOnInvalidChildElement(TextElement child)
    {
      base.ThrowOnInvalidChildElement(child);

      ThrowIfChildIsNoneOfThisTypes(child, typeof(Image));
    }
  }
}
