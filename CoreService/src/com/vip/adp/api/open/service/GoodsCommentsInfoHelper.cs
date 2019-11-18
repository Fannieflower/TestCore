using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.adp.api.open.service{
	
	
	
	public class GoodsCommentsInfoHelper : TBeanSerializer<GoodsCommentsInfo>
	{
		
		public static GoodsCommentsInfoHelper OBJ = new GoodsCommentsInfoHelper();
		
		public static GoodsCommentsInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GoodsCommentsInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("comments".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetComments(value);
					}
					
					
					
					
					
					if ("goodCommentsShare".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGoodCommentsShare(value);
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
		
		
		public void Write(GoodsCommentsInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetComments() != null) {
				
				oprot.WriteFieldBegin("comments");
				oprot.WriteI32((int)structs.GetComments()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGoodCommentsShare() != null) {
				
				oprot.WriteFieldBegin("goodCommentsShare");
				oprot.WriteString(structs.GetGoodCommentsShare());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GoodsCommentsInfo bean){
			
			
		}
		
	}
	
}