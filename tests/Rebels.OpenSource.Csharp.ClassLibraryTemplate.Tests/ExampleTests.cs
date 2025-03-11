// Copyright (C) 2025 Rebels Software
//
// Licensed under the Apache License, Version 2.0 (the "License")
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http:
// www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Rebels.OpenSource.Csharp.ClassLibraryTemplate.Tests;

public class Tests
{
    [Test]
    public void Sum_Test()
    {
        int actual = Example.Sum(1, 3);

        Assert.That(actual, Is.EqualTo(4));
    }
}