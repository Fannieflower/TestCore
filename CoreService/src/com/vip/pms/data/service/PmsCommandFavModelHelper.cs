using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.service{
	
	
	
	public class PmsCommandFavModelHelper : TBeanSerializer<PmsCommandFavModel>
	{
		
		public static PmsCommandFavModelHelper OBJ = new PmsCommandFavModelHelper();
		
		public static PmsCommandFavModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PmsCommandFavModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("buy".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetBuy(value);
					}
					
					
					
					
					
					if ("cut".Equals(schemeField.Trim())){
						
						needSkip = false;
						double value;
						value = iprot.ReadDouble();
						
						structs.SetCut(value);
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
		
		
		public void Write(PmsCommandFavModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBuy() != null) {
				
				oprot.WriteFieldBegin("buy");
				oprot.WriteDouble((double)structs.GetBuy());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("buy can not be null!");
			}
			
			
			if(structs.GetCut() != null) {
				
				oprot.WriteFieldBegin("cut");
				oprot.WriteDouble((double)structs.GetCut());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cut can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PmsCommandFavModel bean){
			
			
		}
		
	}
	
}