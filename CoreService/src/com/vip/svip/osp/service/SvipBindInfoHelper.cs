using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class SvipBindInfoHelper : TBeanSerializer<SvipBindInfo>
	{
		
		public static SvipBindInfoHelper OBJ = new SvipBindInfoHelper();
		
		public static SvipBindInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SvipBindInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("type".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetType(value);
					}
					
					
					
					
					
					if ("nick_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetNick_name(value);
					}
					
					
					
					
					
					if ("figure_url".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetFigure_url(value);
					}
					
					
					
					
					
					if ("bind_time".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetBind_time(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(SvipBindInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetType() != null) {
				
				oprot.WriteFieldBegin("type");
				oprot.WriteI32((int)structs.GetType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("type can not be null!");
			}
			
			
			if(structs.GetNick_name() != null) {
				
				oprot.WriteFieldBegin("nick_name");
				oprot.WriteString(structs.GetNick_name());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFigure_url() != null) {
				
				oprot.WriteFieldBegin("figure_url");
				oprot.WriteString(structs.GetFigure_url());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBind_time() != null) {
				
				oprot.WriteFieldBegin("bind_time");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetBind_time())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SvipBindInfo bean){
			
			
		}
		
	}
	
}