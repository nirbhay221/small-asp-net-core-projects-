#pragma checksum "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\Notification\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "776591494f3acf0717b50d476f1bcceb9842e51d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_Index), @"mvc.1.0.view", @"/Views/Notification/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Notification/Index.cshtml", typeof(AspNetCore.Views_Notification_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using EmpManagement.Models;

#line default
#line hidden
#line 2 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using EmpManagement.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\Nirbhay Malhotra\Downloads\Security (6)\Security (5)\Security (2)\Security\EmpManagement\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"776591494f3acf0717b50d476f1bcceb9842e51d", @"/Views/Notification/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67d6ec5c308294d61a3bbb40d8c9044fb01a3987", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 39, true);
            WriteLiteral("<canvas id=\"canvas\"></canvas>\r\n<html>\r\n");
            EndContext();
            BeginContext(39, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "776591494f3acf0717b50d476f1bcceb9842e51d3625", async() => {
                BeginContext(45, 162, true);
                WriteLiteral("\r\n    <button class=\"ladda-button green expand-right\"><span class=\"label\">Mails For Passport Visa Renewal Sent ...</span> <span class=\"spinner\"></span></button>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(214, 15845, true);
            WriteLiteral(@"
</html>
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/2.1.1/jquery.min.js""></script>

<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.0/css/bootstrap.min.css"">
<script>
    var buttons = document.querySelectorAll('.ladda-button');

    Array.prototype.slice.call(buttons).forEach(function (button) {

        var resetTimeout;

        button.addEventListener('click', function () {

            if (typeof button.getAttribute('data-loading') === 'string') {
                button.removeAttribute('data-loading');
            }
            else {
                button.setAttribute('data-loading', '');
            }

            clearTimeout(resetTimeout);
            resetTimeout = setTimeout(function () {
                button.removeAttribute('data-loading');
            }, 2000);

        }, false);

    });
    function plusOrMinus() {
        return Math.random() < 0.5 ? -1 : 1;
    }

    // Vectors

    function distance(x1, y1, x2,");
            WriteLiteral(@" y2) {
        return Math.sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }

    function getAngle(from, to) {
        return Math.atan2(from.y - to.y, from.x - to.x);
    }

    function getDirectionVector(angle) {
        return {
            x: Math.cos(angle),
            y: Math.sin(angle)
        };
    }

    function getVectorTowards(from, to) {
        var angle = getAngle(from, to);
        return getDirectionVector(angle - Math.PI);
    }



    // Particle
    class Particle {
        constructor(
            context,
            x, y,
            color = '#000',
            diameter = Math.random() * 2 + 0.5,
            direction = Math.random() * Math.PI,
            damping = 0.85,
            steeringRandomness = 0.25,
            steeringForce = 0.1,
            boundaryForce = 0.2,
            movementRadius = Math.random() * 50 + 10
        ) {
            this.position = {
                current: {
                    x,
                  ");
            WriteLiteral(@"  y
                },
                home: {
                    x,
                    y
                }
            };

            this.velocity = {
                x: 0,
                y: 0
            };

            this.direction = direction;

            this.settings = {
                boundaryForce,
                color,
                context,
                diameter,
                damping,
                movementRadius,
                steeringForce,
                steeringRandomness
            };
        }

        move() {
            const { steeringForce, movementRadius, boundaryForce, damping } = this.settings;

            var { current, home } = this.position;

            var { velocity } = this;

            // Add velocity in the current direction.
            var steeringVector = getDirectionVector(this.direction);
            velocity.x += steeringVector.x * steeringForce;
            velocity.y += steeringVector.y * steeringForce;

");
            WriteLiteral(@"            // Randomly steer the direction around
            this.setDirection();

            // Get distance from home coordinates
            var dist = distance(current.x, current.y, home.x, home.y);

            // Apply a force shoving each particle back toward the ""home"" position modulated by the distance from that home point compared to the `movementRadius` threshold.
            if (dist > 0) {
                var steerToHome = getVectorTowards(current, home);

                dist = Math.min(movementRadius, dist);
                dist = (dist / movementRadius);

                velocity.x += steerToHome.x * dist * boundaryForce;
                velocity.y += steerToHome.y * dist * boundaryForce;
            }

            velocity.x *= damping;
            velocity.y *= damping;

            current.x += velocity.x;
            current.y += velocity.y;
        }

        draw() {
            const { diameter, context, color } = this.settings;
            var { current } =");
            WriteLiteral(@" this.position;
            var radius = diameter / 2;

            context.fillStyle = color;
            context.beginPath();
            context.arc(current.x, current.y, radius, 0, Math.PI * 2, false);
            context.closePath();
            context.fill();
        }

        setDirection() {
            const { steeringRandomness } = this.settings;
            this.direction += (Math.random() * 2 - 1) * steeringRandomness;
        }
    }



    // Canvas
    class Canvas {
        constructor(element, particleSpacing = 50, lineWidth = 1, pointerRadius = 100, lineRadius = 100, fps = 1000 / 100) {
            this.canvas = element;
            this.context = element.getContext('2d');

            this.particleSpacing = particleSpacing;
            this.fps = fps;
            this.pointerRadius = pointerRadius;
            this.lineRadius = lineRadius;
            this.lineWidth = lineWidth;

            this.init();
        }

        init() {
            this.stop()");
            WriteLiteral(@";
            this.clear();

            this.resize();

            this.createParticles();
            this.animate();

            this.bind();
        }

        bind() {
            const { canvas } = this;

            window.addEventListener('resize', () => this.init());

            canvas.addEventListener('mousemove', event => {
                event.preventDefault();
                this.setPointer(event.clientX, event.clientY);
            });

            canvas.addEventListener('touchstart', event => {
                event.preventDefault();
                this.setPointer(event.touches[0].clientX, event.touches[0].clientY);
            });

            canvas.addEventListener('touchmove', event => {
                event.preventDefault();
                this.setPointer(event.touches[0].clientX, event.touches[0].clientY);
            });
        }

        resize() {
            this.canvas.width = window.innerWidth;
            this.canvas.height = window.inner");
            WriteLiteral(@"Height;
        }

        setPointer(x, y) {
            this.pointer = { x, y };
        }

        clear() {
            this.context.clearRect(0, 0, this.canvas.width, this.canvas.height);
        }

        createParticles() {
            const { width, height } = this.canvas;
            const { particleSpacing } = this;

            var cols = Math.floor(width / particleSpacing),
                rows = Math.floor(height / particleSpacing),
                colGutter = (particleSpacing + (width - cols * particleSpacing)) / 2,
                rowGutter = (particleSpacing + (height - rows * particleSpacing)) / 2;

            this.particles = [];
            for (let col = 0; col < cols; col++) {
                for (let row = 0; row < rows; row++) {
                    let x = col * particleSpacing + colGutter + particleSpacing * Math.random() * plusOrMinus(),
                        y = row * particleSpacing + rowGutter + particleSpacing * Math.random() * plusOrMinus(),
         ");
            WriteLiteral(@"               r = Math.round(48 + x / width * 25 + y / height * 25),
                        color = 'rgba(' + r + ', 0, 103, 1)',
                        particle = new Particle(this.context, x, y, color);
                    this.particles.push(particle);
                }
            }
        }

        drawLines() {
            if (this.pointer) {
                const { particles, context, pointer, pointerRadius, lineRadius, lineWidth } = this;
                let nearParticles = [];

                particles.forEach(function (particle) {
                    var dist = distance(particle.position.current.x, particle.position.current.y, pointer.x, pointer.y)
                    if (dist < pointerRadius) {
                        nearParticles.push({
                            particle,
                            dist
                        });
                    }
                });


            }
        }

        draw() {
            this.clear();
            if (th");
            WriteLiteral(@"is.particles) {
                for (let i = 0; i < this.particles.length; i++) {
                    let particle = this.particles[i];
                    particle.move();
                    particle.draw();
                }
                this.drawLines();
            }
        }

        animate() {
            var now = Date.now();
            if (this.lastFrameDate === undefined || (now - this.lastFrameDate > this.fps)) {
                this.lastFrameDate = now;

                this.draw();
            }

            this.animationFrame = window.requestAnimationFrame(() => this.animate());
        }

        stop() {
            window.cancelAnimationFrame(this.animationFrame);
        }
    }


    // Init
    new Canvas(document.getElementById('canvas'));</script>
<style>
       .ladda-button {
           position: relative;
           background: none;
           border: 0;
           padding: 0.8em 1em;
           font-size: 1.3em;
           cursor: pointer;");
            WriteLiteral(@"
           outline: 0;
           -webkit-appearance: none;
           -webkit-font-smoothing: antialiased;
           -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
       }

           .ladda-button[data-loading] {
               cursor: default;
           }

           /* Green button */
           .ladda-button.green {
               background: #2aca76;
               color: #fff;
               border-radius: 2px;
               border: 1px solid transparent;
           }

               .ladda-button.green:hover {
                   border-color: rgba( 0, 0, 0, 0.07 );
                   background-color: #2fe688;
               }

               .ladda-button.green[data-loading] {
                   border-color: rgba( 0, 0, 0, 0.07 );
                   background-color: #999;
               }

           .ladda-button .spinner {
               position: absolute;
               width: 32px;
               height: 32px;
               top: 50%;
               margin");
            WriteLiteral(@"-top: -16px;
               opacity: 0;
               background-image: url( data:image/gif;base64,R0lGODlhIAAgAPMAAJmZmf///6+vr8nJybW1tcDAwOjo6Nvb26ioqKOjo7Ozs/Ly8vz8/AAAAAAAAAAAACH/C05FVFNDQVBFMi4wAwEAAAAh/hpDcmVhdGVkIHdpdGggYWpheGxvYWQuaW5mbwAh+QQJCgAAACwAAAAAIAAgAAAE5xDISWlhperN52JLhSSdRgwVo1ICQZRUsiwHpTJT4iowNS8vyW2icCF6k8HMMBkCEDskxTBDAZwuAkkqIfxIQyhBQBFvAQSDITM5VDW6XNE4KagNh6Bgwe60smQUB3d4Rz1ZBApnFASDd0hihh12BkE9kjAJVlycXIg7CQIFA6SlnJ87paqbSKiKoqusnbMdmDC2tXQlkUhziYtyWTxIfy6BE8WJt5YJvpJivxNaGmLHT0VnOgSYf0dZXS7APdpB309RnHOG5gDqXGLDaC457D1zZ/V/nmOM82XiHRLYKhKP1oZmADdEAAAh+QQJCgAAACwAAAAAIAAgAAAE6hDISWlZpOrNp1lGNRSdRpDUolIGw5RUYhhHukqFu8DsrEyqnWThGvAmhVlteBvojpTDDBUEIFwMFBRAmBkSgOrBFZogCASwBDEY/CZSg7GSE0gSCjQBMVG023xWBhklAnoEdhQEfyNqMIcKjhRsjEdnezB+A4k8gTwJhFuiW4dokXiloUepBAp5qaKpp6+Ho7aWW54wl7obvEe0kRuoplCGepwSx2jJvqHEmGt6whJpGpfJCHmOoNHKaHx61WiSR92E4lbFoq+B6QDtuetcaBPnW6+O7wDHpIiK9SaVK5GgV543tzjgGcghAgAh+QQJCgAAACwAAAAAIAAgAAAE7hDISSkxpOrN5zFHNWRdhSiVoVLHspRUMoyUakyEe8PTPCATW9A14E0UvuAKMNAZKYUZCiBMuB");
            WriteLiteral(@"akSQKG8G2FzUWox2AUtAQFcBKlVQoLgQReZhQlCIJesQXI5B0CBnUMOxMCenoCfTCEWBsJColTMANldx15BGs8B5wlCZ9Po6OJkwmRpnqkqnuSrayqfKmqpLajoiW5HJq7FL1Gr2mMMcKUMIiJgIemy7xZtJsTmsM4xHiKv5KMCXqfyUCJEonXPN2rAOIAmsfB3uPoAK++G+w48edZPK+M6hLJpQg484enXIdQFSS1u6UhksENEQAAIfkECQoAAAAsAAAAACAAIAAABOcQyEmpGKLqzWcZRVUQnZYg1aBSh2GUVEIQ2aQOE+G+cD4ntpWkZQj1JIiZIogDFFyHI0UxQwFugMSOFIPJftfVAEoZLBbcLEFhlQiqGp1Vd140AUklUN3eCA51C1EWMzMCezCBBmkxVIVHBWd3HHl9JQOIJSdSnJ0TDKChCwUJjoWMPaGqDKannasMo6WnM562R5YluZRwur0wpgqZE7NKUm+FNRPIhjBJxKZteWuIBMN4zRMIVIhffcgojwCF117i4nlLnY5ztRLsnOk+aV+oJY7V7m76PdkS4trKcdg0Zc0tTcKkRAAAIfkECQoAAAAsAAAAACAAIAAABO4QyEkpKqjqzScpRaVkXZWQEximw1BSCUEIlDohrft6cpKCk5xid5MNJTaAIkekKGQkWyKHkvhKsR7ARmitkAYDYRIbUQRQjWBwJRzChi9CRlBcY1UN4g0/VNB0AlcvcAYHRyZPdEQFYV8ccwR5HWxEJ02YmRMLnJ1xCYp0Y5idpQuhopmmC2KgojKasUQDk5BNAwwMOh2RtRq5uQuPZKGIJQIGwAwGf6I0JXMpC8C7kXWDBINFMxS4DKMAWVWAGYsAdNqW5uaRxkSKJOZKaU3tPOBZ4DuK2LATgJhkPJMgTwKCdFjyPHEnKxFCDhEAACH5BAkKAAAALAAAAAAgACAAAATzEMhJaVKp6s2nIkolIJ2WkBShpkVRWqqQrhLSEu9MZJKK9y1ZrqYK9WiClmvoUaF8gIQSNe");
            WriteLiteral(@"F1Er4MNFn4SRSDARWroAIETg1iVwuHjYB1kYc1mwruwXKC9gmsJXliGxc+XiUCby9ydh1sOSdMkpMTBpaXBzsfhoc5l58Gm5yToAaZhaOUqjkDgCWNHAULCwOLaTmzswadEqggQwgHuQsHIoZCHQMMQgQGubVEcxOPFAcMDAYUA85eWARmfSRQCdcMe0zeP1AAygwLlJtPNAAL19DARdPzBOWSm1brJBi45soRAWQAAkrQIykShQ9wVhHCwCQCACH5BAkKAAAALAAAAAAgACAAAATrEMhJaVKp6s2nIkqFZF2VIBWhUsJaTokqUCoBq+E71SRQeyqUToLA7VxF0JDyIQh/MVVPMt1ECZlfcjZJ9mIKoaTl1MRIl5o4CUKXOwmyrCInCKqcWtvadL2SYhyASyNDJ0uIiRMDjI0Fd30/iI2UA5GSS5UDj2l6NoqgOgN4gksEBgYFf0FDqKgHnyZ9OX8HrgYHdHpcHQULXAS2qKpENRg7eAMLC7kTBaixUYFkKAzWAAnLC7FLVxLWDBLKCwaKTULgEwbLA4hJtOkSBNqITT3xEgfLpBtzE/jiuL04RGEBgwWhShRgQExHBAAh+QQJCgAAACwAAAAAIAAgAAAE7xDISWlSqerNpyJKhWRdlSAVoVLCWk6JKlAqAavhO9UkUHsqlE6CwO1cRdCQ8iEIfzFVTzLdRAmZX3I2SfZiCqGk5dTESJeaOAlClzsJsqwiJwiqnFrb2nS9kmIcgEsjQydLiIlHehhpejaIjzh9eomSjZR+ipslWIRLAgMDOR2DOqKogTB9pCUJBagDBXR6XB0EBkIIsaRsGGMMAxoDBgYHTKJiUYEGDAzHC9EACcUGkIgFzgwZ0QsSBcXHiQvOwgDdEwfFs0sDzt4S6BK4xYjkDOzn0unFeBzOBijIm1Dgmg5YFQwsCMjp1oJ8LyIAACH5BAkKAAAALAAAAAAgACAAAATwEMhJaVKp6s2nIkqFZF2VIBWhUsJaTokqUCoBq+E71SRQeyqUToLA7V");
            WriteLiteral(@"xF0JDyIQh/MVVPMt1ECZlfcjZJ9mIKoaTl1MRIl5o4CUKXOwmyrCInCKqcWtvadL2SYhyASyNDJ0uIiUd6GGl6NoiPOH16iZKNlH6KmyWFOggHhEEvAwwMA0N9GBsEC6amhnVcEwavDAazGwIDaH1ipaYLBUTCGgQDA8NdHz0FpqgTBwsLqAbWAAnIA4FWKdMLGdYGEgraigbT0OITBcg5QwPT4xLrROZL6AuQAPUS7bxLpoWidY0JtxLHKhwwMJBTHgPKdEQAACH5BAkKAAAALAAAAAAgACAAAATrEMhJaVKp6s2nIkqFZF2VIBWhUsJaTokqUCoBq+E71SRQeyqUToLA7VxF0JDyIQh/MVVPMt1ECZlfcjZJ9mIKoaTl1MRIl5o4CUKXOwmyrCInCKqcWtvadL2SYhyASyNDJ0uIiUd6GAULDJCRiXo1CpGXDJOUjY+Yip9DhToJA4RBLwMLCwVDfRgbBAaqqoZ1XBMHswsHtxtFaH1iqaoGNgAIxRpbFAgfPQSqpbgGBqUD1wBXeCYp1AYZ19JJOYgH1KwA4UBvQwXUBxPqVD9L3sbp2BNk2xvvFPJd+MFCN6HAAIKgNggY0KtEBAAh+QQJCgAAACwAAAAAIAAgAAAE6BDISWlSqerNpyJKhWRdlSAVoVLCWk6JKlAqAavhO9UkUHsqlE6CwO1cRdCQ8iEIfzFVTzLdRAmZX3I2SfYIDMaAFdTESJeaEDAIMxYFqrOUaNW4E4ObYcCXaiBVEgULe0NJaxxtYksjh2NLkZISgDgJhHthkpU4mW6blRiYmZOlh4JWkDqILwUGBnE6TYEbCgevr0N1gH4At7gHiRpFaLNrrq8HNgAJA70AWxQIH1+vsYMDAzZQPC9VCNkDWUhGkuE5PxJNwiUK4UfLzOlD4WvzAHaoG9nxPi5d+jYUqfAhhykOFwJWiAAAIfkECQoAAAAsAAAAACAAIAAABPAQyElpUqnqzaciSoVkXVUMFaFSwlpOCcMYlErAavhOMnNLNo8KsZ");
            WriteLiteral(@"sMZItJEIDIFSkLGQoQTNhIsFehRww2CQLKF0tYGKYSg+ygsZIuNqJksKgbfgIGepNo2cIUB3V1B3IvNiBYNQaDSTtfhhx0CwVPI0UJe0+bm4g5VgcGoqOcnjmjqDSdnhgEoamcsZuXO1aWQy8KAwOAuTYYGwi7w5h+Kr0SJ8MFihpNbx+4Erq7BYBuzsdiH1jCAzoSfl0rVirNbRXlBBlLX+BP0XJLAPGzTkAuAOqb0WT5AH7OcdCm5B8TgRwSRKIHQtaLCwg1RAAAOwAAAAAAAAAAAA==);
           }

           .ladda-button.expand-right .spinner {
               right: 0.8em;
           }

           .ladda-button.expand-right[data-loading] {
               padding-right: 56px;
           }

               .ladda-button.expand-right[data-loading] .spinner {
                   opacity: 1;
               }

           /*************************************
    * EASING
    */

           .ladda-button,
           .ladda-button .spinner,
           .ladda-button .label {
               -webkit-transition: 0.3s cubic-bezier(0.175, 0.885, 0.320, 1.275) all;
               -moz-transition: 0.3s cubic-bezier(0.175, 0.885, 0.320, 1.275) all;
               -ms-transition: 0.3s cubic-bezier(0");
            WriteLiteral(@".175, 0.885, 0.320, 1.275) all;
               transition: 0.3s cubic-bezier(0.175, 0.885, 0.320, 1.275) all;
           }

       html, body {
           margin: 0;
           overflow: hidden;
           height: 100vh;
           background: linear-gradient(-25deg, #7aeaaf, #029eff);
       }

       canvas {
           display: block;
           margin: 0;
           position: absolute;
           -webkit-tap-highlight-color: rgba(0, 0, 0, 0);
       }
</style>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
